using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class CategoryRegisterForJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        Category category = new Category();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_OnClick(object sender, EventArgs e)
        {
            var registerEmail = Session["RegisterEmail"].ToString();
            var Id = db.JobSeekers.Where(x => x.Email == registerEmail).Select(x => x.Id).ToList().LastOrDefault();

            category.JobSeekerCategoryId = Id;
            category.HouseTutorClassPlay_5 = play_5Return();
            category.HouseTutorClass6_8 = class6_8Return();
            category.HouseTutorClass9_10 = class9_10Return();
            category.HouseTutorClass11_12 = class11_12Return();
            category.HouseTutorPhysics = PhysicsReturn();
            category.HouseTutorMath = MathReturn();
            category.HouseTutorChemistry = ChemistryReturn();
            category.HouseTutorBangla = BanglaReturn();
            category.HouseTutorEnglish = EnglishReturn();
            category.HouseTutorICT = IctReturn();
            category.HouseTutorAccounting = AccountingReturn();
            category.DataEntryBasicLevel = DataEntryBaicLevelReturn();
            category.DataEntrySecondaryLevel = DataEntrySecondReturn();
            category.DataEntryHigherLevel = DataEntryHigherReturn();
            category.EventManagerCorporateMeeting = EventManagerCorporateMeetingReturn();
            category.EventManagerFamilyMeeting = EventManagerFamilyMeetingReturn();
            category.EventManagerParty = EventManagerPartyMeetingReturn();
            category.PhotographyPortrait = PhotographyPortraitReturn();
            category.PhotographyParty = PhotographyPartyReturn();
            category.PhotographyFamily = PhotographyFamilyReturn();
            category.PhotographyInstitution = PhotgraphyInstituitionReturn();
            category.GraphicsDesignPhotoshop = GraphicsDesignPhotoshopReturn();
            category.GraphicsDesignIllustrator = GraphicsDesignIllustratorReturn();
            category.TransporterBothWay = TransporterBothWayReturn();
            category.TransporterOneWay = TransporterOneWayReturn();
            category.AdditionalDirectorFilm = AdditionalDirectorFilmReturn();
            category.AdditionalDirectorShortFilm = AdditionalDirectorShortReturn();
            category.AdditionalDirectorDocumentary = AdditionalDirectorDocumentaryReturn();
            category.ConsultantBusinessTransformation = TransformationReturn();
            category.ConsultantEngineeringConsultants = EngineeringReturn();
            category.ConsultantEducationalConsultants = EducationalReturn();
            category.ConsultantHumanResourcesConsultants = HumanResourcesReturn();
            category.ConsultantImmigrationConsultants = ImmigrationReturn();
            category.ConsultantInternetConsultants = InternetReturn();
            category.ConsultantInformation_TechnologyConsultants = InformationTechnologyReturn();
            category.ConsultantInterimManagers = InterimManagerReturn();
            category.ConsultantMarketingConsultants = MarketingReturn();
            category.ConsultantProcessConsultants = ProcessReturn();
            category.ConsultantPublic_relationsConsultants = PublicRelationReturn();
            category.ConsultantPerformanceConsultants = PerformanceReturn();
            category.ConsultantSalesConsultants = SalesReturn();
            category.ConsultantStrategyConsultants = StrategyReturn();
            category.Consultant3DConsultants = D3Return();
            category.WebDesignStatic = WebDesignStaticReturn();
            category.WebDesignDynamic = WebDesignDynamicReturn();
            db.Categories.Add(category);
            db.SaveChanges();

            Session["Email"] = Session["RegisterEmail"].ToString();
            Session["JobId"] = "JobSeeker";
            Response.Redirect("DashBoardJobSeeker.aspx");

        }




        public string play_5Return()
        {

            if (play_5Checkbox.Checked)
            {

                return "yes";

            }

            else
            {
                return null;
            }

        }



        public string class6_8Return()
        {
            if (clas6_8Checkbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string class9_10Return()
        {
            if (class9_10Checkbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string class11_12Return()
        {
            if (class11_12Checkbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PhysicsReturn()
        {
            if (physicsCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string MathReturn()
        {
            if (mathCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string BanglaReturn()
        {
            if (banglaCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string ChemistryReturn()
        {
            if (chemistryCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string EnglishReturn()
        {
            if (englishCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }


        public string IctReturn()
        {
            if (ictCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string AccountingReturn()
        {
            if (accountingCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string DataEntryBaicLevelReturn()
        {
            if (basicLevelCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string DataEntrySecondReturn()
        {
            if (secondaryLevelCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string DataEntryHigherReturn()
        {
            if (higherLevelCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string EventManagerCorporateMeetingReturn()
        {
            if (corporateMeetingCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string EventManagerFamilyMeetingReturn()
        {
            if (familyEventCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string EventManagerPartyMeetingReturn()
        {
            if (partyCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PhotographyPortraitReturn()
        {
            if (portraitCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PhotographyPartyReturn()
        {
            if (partyPhotographyCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PhotographyFamilyReturn()
        {
            if (familyPhotographyCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PhotgraphyInstituitionReturn()
        {
            if (institutionPhotographyCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string GraphicsDesignPhotoshopReturn()
        {
            if (photoshopCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string GraphicsDesignIllustratorReturn()
        {
            if (illustratorCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string TransporterBothWayReturn()
        {
            if (bothWayCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string TransporterOneWayReturn()
        {
            if (oneWayCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string AdditionalDirectorFilmReturn()
        {
            if (filmCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string AdditionalDirectorShortReturn()
        {
            if (shortFilmCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string AdditionalDirectorDocumentaryReturn()
        {
            if (documentaryCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string TransformationReturn()
        {
            if (businessTransformationCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string EngineeringReturn()
        {
            if (engineeringConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string EducationalReturn()
        {
            if (educationalConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string HumanResourcesReturn()
        {
            if (humanResourcesConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string ImmigrationReturn()
        {
            if (immigrationConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string InternetReturn()
        {
            if (internetConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string InformationTechnologyReturn()
        {
            if (informationTechnologyConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string InterimManagerReturn()
        {
            if (interimManagersCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string MarketingReturn()
        {
            if (marketingConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string ProcessReturn()
        {
            if (processConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string PublicRelationReturn()
        {
            if (publicRelationConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }

        public string PerformanceReturn()
        {
            if (performanceConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string SalesReturn()
        {
            if (salesConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string StrategyReturn()
        {
            if (strategyConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string D3Return()
        {
            if (D3ConsultantCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string WebDesignStaticReturn()
        {
            if (staticCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }
        public string WebDesignDynamicReturn()
        {
            if (dynamicCheckbox.Checked)
            {
                return "yes";
            }
            else
            {
                return null;
            }
        }







    }
}