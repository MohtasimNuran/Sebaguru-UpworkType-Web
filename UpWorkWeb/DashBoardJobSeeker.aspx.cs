using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class DashBoardJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities(); 
        DateTime now = DateTime.Now.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
                var jobId = Session["JobId"].ToString();

                //profile image
                //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();

                //message count
                var msgCount = db.Messages.Count(x => x.Receiver == email && x.Status == "unread");
                msgCountLabel.Text = msgCount.ToString();
                msgCount2Label.Text = msgCount.ToString();

                //notification count
                var count = db.Notifications.Count(x => x.JobSeeker.Email == email && x.Status == "unread");
                countLabel.Text = count.ToString();
                notiCountLabel.Text = count.ToString();

                //dashboard name
                nameLabel.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Full_Name).ToList().LastOrDefault();

                //Applied job list for job seeker
                var appliedJobList = db.AppliedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => new
                {
                    JobCode = x.PostJob.JobCode,
                    JobTitle = x.PostJob.JobTitle,
                    Type = x.PostJob.Type,
                    Location = x.PostJob.Location,
                    Category = x.PostJob.Category,
                    DeadLineDate = x.PostJob.DeadLineDate,
                    Payment = x.PostJob.Payment,
                    CoverPhoto = x.PostJob.CoverPhoto,
                    Count = db.AppliedJobSeekers.Count(y => y.PostJobId == x.PostJobId),
                    //Picture = db.AppliedJobSeekers.Where(z => z.PostJob.JobCode == x.PostJob.JobCode).Select(z => z.JobSeeker.Picture).ToList(),

                }).ToList();

                appliedJobListRepeater.DataSource = appliedJobList;
                appliedJobListRepeater.DataBind();
                appliedLabel.Text = appliedJobList.Count.ToString();


                //working job list
                var workingJobList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email && x.Status == "incomplete").Select(x => new
                       {
                           x.PostJob.JobTitle,
                           x.PostJob.JobCode,
                           x.PostJob.CoverPhoto,
                           x.PostJob.Category,
                           x.PostJob.CompanyId,
                           x.PostJob.JobProviderCompany.CompanyName,
                           x.PostJob.PersonalId,
                           x.PostJob.JobProviderPersonal.FullName,
                           x.ReviewForIncomplete,
                           x.Status
                       }).ToList();
                workingJobListRepeater.DataSource = workingJobList;
                workingJobListRepeater.DataBind();

                //working count
                workingCountLabel.Text = workingJobList.Count.ToString();


                //completed job list
                var selectedJobSeekerList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email && x.Status == "complete").Select(x => new
                       {
                           x.PostJob.JobTitle,
                           x.PostJob.JobCode,
                           x.PostJob.CoverPhoto,
                           x.PostJob.Category,
                           x.PostJob.CompanyId,
                           x.PostJob.JobProviderCompany.CompanyName,
                           x.PostJob.PersonalId,
                           x.PostJob.JobProviderPersonal.FullName,
                           x.ReviewForComplete,
                           x.Status
                       }).ToList();
                completedJobListRepeater.DataSource = selectedJobSeekerList;
                completedJobListRepeater.DataBind();


                //review job seeker
                var reviewJobSeekerList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => new
                       {
                           x.PostJob.JobTitle,
                           x.PostJob.JobCode,
                           x.PostJob.CoverPhoto,
                           x.PostJob.Category,
                           x.PostJob.CompanyId,
                           x.PostJob.JobProviderCompany.CompanyName,
                           x.PostJob.PersonalId,
                           x.PostJob.JobProviderPersonal.FullName,
                           x.ReviewForComplete,
                           x.ReviewForIncomplete,
                           x.Status
                       }).ToList();
                reviewListRepeater.DataSource = reviewJobSeekerList;
                reviewListRepeater.DataBind();

                //job list

                //var category = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Category).ToList().LastOrDefault();
                //var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == category).ToList();
                //jobCountLabel.Text = jobList.Count.ToString();
                //jobListRepeater.DataSource = jobList;
                //jobListRepeater.DataBind();

                //new job list technique

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


                if (categoryStringList.Count == 1)
                {
                    var s1 = categoryStringList[0];
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
                else if (categoryStringList.Count == 2)
                {
                    var s1 = categoryStringList[0];
                    var s2 = categoryStringList[1];
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
                else if (categoryStringList.Count == 3)
                {
                    var s1 = categoryStringList[0];
                    var s2 = categoryStringList[1];
                    var s3 = categoryStringList[2];
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
                else if (categoryStringList.Count == 4)
                {
                    var s1 = categoryStringList[0];
                    var s2 = categoryStringList[1];
                    var s3 = categoryStringList[2];
                    var s4 = categoryStringList[3];
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ThenByDescending(x => x.Category == s4).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
                else if (categoryStringList.Count >= 5)
                {
                    var s1 = categoryStringList[0];
                    var s2 = categoryStringList[1];
                    var s3 = categoryStringList[2];
                    var s4 = categoryStringList[3];
                    var s5 = categoryStringList[4];
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderByDescending(x => x.Category == s1).ThenByDescending(x => x.Category == s2).ThenByDescending(x => x.Category == s3).ThenByDescending(x => x.Category == s4).ThenByDescending(x => x.Category == s5).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
                else if (categoryStringList.Count == 0)
                {
                    var jobListtry = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                    jobListRepeater.DataSource = jobListtry;
                    jobListRepeater.DataBind();
                }
            }
        }

        protected void appliedJobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobCode = e.CommandName.ToString();
            if (jobCode != "")
            {
                Session["JobCode"] = jobCode;
                Response.Redirect("JobDetailsWithAppliedCandidate.aspx");
            }
            else
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithAppliedCandidate.aspx");
            }
        }

        protected void workingJobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "CompanyId")
            {
                Session["CompanyId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderCompany.aspx");
            }
            else if (e.CommandName == "PersonalId")
            {
                Session["PersonalId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderPersonal.aspx");
            }
            else if (e.CommandName == "JobTitle")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
            else if (e.CommandName == "JobCode")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
        }

        protected void completedJobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "CompanyId")
            {
                Session["CompanyId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderCompany.aspx");
            }
            else if (e.CommandName == "PersonalId")
            {
                Session["PersonalId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderPersonal.aspx");
            }
            else if (e.CommandName == "JobTitle")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
            else if (e.CommandName == "JobCode")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
        }

        protected void jobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Session["JobCode"] = e.CommandArgument.ToString();
            Response.Redirect("JobDetails.aspx");
        }

        protected void logOutButton_OnClick(object sender, EventArgs e)
        {
            Session["Email"] = "";
            Session["JobCode"] = "";
            Session["EmailForReview"] = "";
            Session["EmailForProfile"] = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}