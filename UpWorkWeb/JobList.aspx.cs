using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UpWorkWeb
{
    public partial class JobList : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        private string jobId;
        DateTime now = DateTime.Now.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Session["Email"] as string))  //not null or i have email
                {
                    var email = Session["Email"].ToString();
                    jobId = Session["JobId"].ToString();

                    //profile image
                    //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();

                    if (jobId == "PersonalId")
                    {
                        //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                        //Repeater2.DataSource = jobList;
                        //Repeater2.DataBind();
                        Response.Redirect("JobListJobProvider.aspx");
                    }
                    else if (jobId == "CompanyId")
                    {
                        //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                        //Repeater2.DataSource = jobList;
                        //Repeater2.DataBind();
                        Response.Redirect("JobListJobProvider.aspx");
                    }
                    else if (jobId == "JobSeeker")
                    {
                        //var category = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Category).ToList().LastOrDefault();
                        //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == category).ToList();

                        //var category = db.JobSeekers.Where(x=>x.Email==email && x.Category1
                        //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(db.Categories.Any()).ToList();


                        List<Category> categoryList = db.Categories.Where(x => x.JobSeeker.Email == email).Select(x => x).ToList();

                        List<string> categoryStringList = new List<string>();


                        for (int i = 0; i < categoryList.Count; i++)
                        {
                            if (categoryList[i].HouseTutorClassPlay_5 == "yes")
                            {
                                categoryStringList.Add("HouseTutorClassPlay_5");
                            }
                            if (categoryList[i].HouseTutorClass6_8 == "yes")
                            {
                                categoryStringList.Add("HouseTutorClass6_8");
                            }
                            if (categoryList[i].HouseTutorClass9_10 == "yes")
                            {
                                categoryStringList.Add("HouseTutorClass9_10");
                            }
                            if (categoryList[i].HouseTutorClass11_12 == "yes")
                            {
                                categoryStringList.Add("HouseTutorClass11_12");
                            }
                            if (categoryList[i].HouseTutorPhysics == "yes")
                            {
                                categoryStringList.Add("HouseTutorPhysics");
                            }
                            if (categoryList[i].HouseTutorMath == "yes")
                            {
                                categoryStringList.Add("HouseTutorMath");
                            }
                            if (categoryList[i].HouseTutorChemistry == "yes")
                            {
                                categoryStringList.Add("HouseTutorChemistry");
                            }
                            if (categoryList[i].HouseTutorBangla == "yes")
                            {
                                categoryStringList.Add("HouseTutorBangla");
                            }
                            if (categoryList[i].HouseTutorEnglish == "yes")
                            {
                                categoryStringList.Add("HouseTutorEnglish");
                            }
                            if (categoryList[i].HouseTutorICT == "yes")
                            {
                                categoryStringList.Add("HouseTutorICT");
                            }
                            if (categoryList[i].HouseTutorAccounting == "yes")
                            {
                                categoryStringList.Add("HouseTutorAccounting");
                            }
                            if (categoryList[i].DataEntryBasicLevel == "yes")
                            {
                                categoryStringList.Add("DataEntryBasicLevel");
                            } if (categoryList[i].DataEntrySecondaryLevel == "yes")
                            {
                                categoryStringList.Add("DataEntrySecondaryLevel");
                            }
                            if (categoryList[i].DataEntryHigherLevel == "yes")
                            {
                                categoryStringList.Add("DataEntryHigherLevel");
                            }
                            if (categoryList[i].EventManagerCorporateMeeting == "yes")
                            {
                                categoryStringList.Add("EventManagerCorporateMeeting");
                            }
                            if (categoryList[i].EventManagerFamilyMeeting == "yes")
                            {
                                categoryStringList.Add("EventManagerFamilyMeeting");
                            }
                            if (categoryList[i].EventManagerParty == "yes")
                            {
                                categoryStringList.Add("EventManagerParty");
                            }
                            if (categoryList[i].PhotographyPortrait == "yes")
                            {
                                categoryStringList.Add("PhotographyPortrait");
                            }
                            if (categoryList[i].PhotographyParty == "yes")
                            {
                                categoryStringList.Add("PhotographyParty");
                            }
                            if (categoryList[i].PhotographyFamily == "yes")
                            {
                                categoryStringList.Add("PhotographyFamily");
                            }
                            if (categoryList[i].PhotographyInstitution == "yes")
                            {
                                categoryStringList.Add("PhotographyInstitution");
                            }
                            if (categoryList[i].GraphicsDesignPhotoshop == "yes")
                            {
                                categoryStringList.Add("GraphicsDesignPhotoshop");
                            }
                            if (categoryList[i].GraphicsDesignIllustrator == "yes")
                            {
                                categoryStringList.Add("GraphicsDesignIllustrator");
                            }
                            if (categoryList[i].TransporterBothWay == "yes")
                            {
                                categoryStringList.Add("TransporterBothWay");
                            } if (categoryList[i].TransporterOneWay == "yes")
                            {
                                categoryStringList.Add("TransporterOneWay");
                            }
                            if (categoryList[i].AdditionalDirectorFilm == "yes")
                            {
                                categoryStringList.Add("AdditionalDirectorFilm");
                            }
                            if (categoryList[i].AdditionalDirectorShortFilm == "yes")
                            {
                                categoryStringList.Add("AdditionalDirectorShortFilm");
                            }
                            if (categoryList[i].AdditionalDirectorDocumentary == "yes")
                            {
                                categoryStringList.Add("AdditionalDirectorDocumentary");
                            }
                            if (categoryList[i].ConsultantBusinessTransformation == "yes")
                            {
                                categoryStringList.Add("ConsultantBusinessTransformation");
                            }
                            if (categoryList[i].ConsultantEngineeringConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantEngineeringConsultants");
                            }
                            if (categoryList[i].ConsultantEducationalConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantEducationalConsultants");
                            }
                            if (categoryList[i].ConsultantHumanResourcesConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantHumanResourcesConsultants");
                            }
                            if (categoryList[i].ConsultantImmigrationConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantImmigrationConsultants");
                            }
                            if (categoryList[i].ConsultantInternetConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantInternetConsultants");
                            }
                            if (categoryList[i].ConsultantInformation_TechnologyConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantInformation_TechnologyConsultants");
                            }
                            if (categoryList[i].ConsultantInterimManagers == "yes")
                            {
                                categoryStringList.Add("ConsultantInterimManagers");
                            }
                            if (categoryList[i].ConsultantMarketingConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantMarketingConsultants");
                            }
                            if (categoryList[i].ConsultantProcessConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantProcessConsultants");
                            }
                            if (categoryList[i].ConsultantPublic_relationsConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantPublic_relationsConsultants");
                            }
                            if (categoryList[i].ConsultantPerformanceConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantPerformanceConsultants");
                            }
                            if (categoryList[i].ConsultantSalesConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantSalesConsultants");
                            }
                            if (categoryList[i].ConsultantStrategyConsultants == "yes")
                            {
                                categoryStringList.Add("ConsultantStrategyConsultants");
                            }
                            if (categoryList[i].Consultant3DConsultants == "yes")
                            {
                                categoryStringList.Add("Consultant3DConsultants");
                            }
                            if (categoryList[i].WebDesignStatic == "yes")
                            {
                                categoryStringList.Add("WebDesignStatic");
                            }
                            if (categoryList[i].WebDesignDynamic == "yes")
                            {
                                categoryStringList.Add("WebDesignDynamic");
                            }

                        }


                        if (categoryStringList.Count==1)
                        {
                            var s1 = categoryStringList[0];
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }
                        else if (categoryStringList.Count == 2)
                        {
                            var s1 = categoryStringList[0];
                            var s2 = categoryStringList[1];
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }
                        else if (categoryStringList.Count == 3)
                        {
                            var s1 = categoryStringList[0];
                            var s2 = categoryStringList[1];
                            var s3 = categoryStringList[2];
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }
                        else if (categoryStringList.Count == 4)
                        {
                            var s1 = categoryStringList[0];
                            var s2 = categoryStringList[1];
                            var s3 = categoryStringList[2];
                            var s4 = categoryStringList[3];
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ThenByDescending(x => x.Category == s4).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }
                        else if (categoryStringList.Count >= 5)
                        {
                            var s1 = categoryStringList[0];
                            var s2 = categoryStringList[1];
                            var s3 = categoryStringList[2];
                            var s4 = categoryStringList[3];
                            var s5 = categoryStringList[4];
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ThenByDescending(x => x.Category == s4).ThenByDescending(x => x.Category == s5).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }
                        else if (categoryStringList.Count == 0)
                        {
                            var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                            Repeater2.DataSource = jobListtry;
                            Repeater2.DataBind();
                        }

                    }
                }
                else  //if null
                {
                    //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                    //Repeater2.DataSource = jobList;
                    //Repeater2.DataBind();
                    Response.Redirect("JobListPartial.aspx");
                }
            }

        }


        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobId1 = Session["JobId"].ToString();

            if (jobId1 == "PersonalId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "CompanyId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "JobSeeker")
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetails.aspx");
            }
        }

        protected void logOutButton_OnClick(object sender, EventArgs e)
        {
            Session["Email"] = "";
            Session["JobCode"] = "";
            Session["EmailForReview"] = "";
            Session["EmailForProfile"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void categoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoryDropDownList.SelectedValue == "Category")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Category == categoryDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void typeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDropDownList.SelectedValue == "Type")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Type == typeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void timeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (timeDropDownList.SelectedValue == "Time")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Per == timeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }
    }
}