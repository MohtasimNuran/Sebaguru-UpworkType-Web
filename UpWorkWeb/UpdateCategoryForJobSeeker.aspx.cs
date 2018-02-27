using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class UpdateCategoryForJobSeeker : System.Web.UI.Page
    {
        private UpWorkDBEntities db = new UpWorkDBEntities();
        Category category = new Category();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
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



                foreach (var checkboxValue in categoryStringList)
                {
                    if (checkboxValue == "HouseTutorClassPlay_5")
                    {
                        play_5Checkbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorClass6_8")
                    {
                        clas6_8Checkbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorClass9_10")
                    {
                        class9_10Checkbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorClass11_12")
                    {
                        class11_12Checkbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorPhysics")
                    {
                        physicsCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorMath")
                    {
                        mathCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorChemistry")
                    {
                        chemistryCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorBangla")
                    {
                        banglaCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorEnglish")
                    {
                        englishCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorICT")
                    {
                        ictCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "HouseTutorAccounting")
                    {

                        accountingCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "DataEntryBasicLevel")
                    {
                        basicLevelCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "DataEntrySecondaryLevel")
                    {
                        secondaryLevelCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "DataEntryHigherLevel")
                    {
                        higherLevelCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "EventManagerCorporateMeeting")
                    {
                        corporateMeetingCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "EventManagerFamilyMeeting")
                    {
                        familyEventCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "EventManagerParty")
                    {
                        partyCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "PhotographyPortrait")
                    {

                        portraitCheckbox.Checked = true;
                    }


                    else if (checkboxValue == "PhotographyParty")
                    {
                        partyPhotographyCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "PhotographyFamily")
                    {
                        familyPhotographyCheckbox.Checked = true;

                    }

                    else if (checkboxValue == "PhotographyInstitution")
                    {
                        institutionPhotographyCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "GraphicsDesignPhotoshop")
                    {

                        photoshopCheckbox.Checked = true;
                    }


                    else if (checkboxValue == "GraphicsDesignIllustrator")
                    {
                        illustratorCheckbox.Checked = true;

                    }

                    else if (checkboxValue == "TransporterBothWay")
                    {
                        bothWayCheckbox.Checked = true;

                    }

                    else if (checkboxValue == "TransporterOneWay")
                    {
                        oneWayCheckbox.Checked = true;

                    }

                    else if (checkboxValue == "AdditionalDirectorFilm")
                    {

                        filmCheckbox.Checked = true;
                    }

                    else if (checkboxValue == "AdditionalDirectorShortFilm")
                    {
                        shortFilmCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "AdditionalDirectorDocumentary")
                    {
                        documentaryCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantBusinessTransformation")
                    {
                        businessTransformationCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantEngineeringConsultants")
                    {
                        engineeringConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantEducationalConsultants")
                    {
                        educationalConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantHumanResourcesConsultants")
                    {
                        humanResourcesConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantImmigrationConsultants")
                    {
                        immigrationConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantInternetConsultants")
                    {
                        internetConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantInformation_TechnologyConsultants")
                    {
                        informationTechnologyConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantInterimManagers")
                    {
                        interimManagersCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantMarketingConsultants")
                    {
                        marketingConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantProcessConsultants")
                    {
                        processConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantPublic_relationsConsultants")
                    {
                        publicRelationConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantPerformanceConsultants")
                    {
                        performanceConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantSalesConsultants")
                    {
                        salesConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "ConsultantStrategyConsultants")
                    {
                        strategyConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "Consultant3DConsultants")
                    {
                        D3ConsultantCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "WebDesignStatic")
                    {
                        staticCheckbox.Checked = true;
                    }
                    else if (checkboxValue == "WebDesignDynamic")
                    {
                        dynamicCheckbox.Checked = true;
                    }

                }
            }

          


        }

        protected void UpdateButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();


            category = db.Categories.Where(x => x.JobSeeker.Email == email).Select(x => x).First();


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
            
            db.SaveChanges();

            Response.Redirect("UpdateCategoryForJobSeeker.aspx");

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