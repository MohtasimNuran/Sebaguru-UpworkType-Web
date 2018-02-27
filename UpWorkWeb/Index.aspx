<%@ Page Title="" Language="C#" MasterPageFile="~/PartialMasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UpWorkWeb.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Seba Guru</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%--    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />--%>
    <link href="Content/w3.css" rel="stylesheet" />
    <link href="Content/customScrollBar.css" rel="stylesheet" />
    <style type="text/css">
        .btnLeftAlign {
            display: inline-block;
            margin-bottom: 0;
            font-weight: normal;
            text-align: left;
            vertical-align: middle;
            -ms-touch-action: manipulation;
            touch-action: manipulation;
            cursor: pointer;
            background-image: none;
            border: 1px solid transparent;
            white-space: nowrap;
            padding: 10px 5px;
            font-size: 14px;
            line-height: 1.42857143;
            border-radius: 0px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        .checkboxLarge {
            height: 20px;
            width: 20px;
        }

        .scrollCustom {
            height: 500px;
            overflow-y: scroll;
        }





        .switch {
            position: relative;
            display: inline-block;
            width: 42px;
            height: 15px;
        }

            .switch input {
                display: none;
            }

        .slider {
            position: absolute;
            cursor: pointer;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: #ccc;
            -webkit-transition: .4s;
            transition: .4s;
        }

            .slider:before {
                position: absolute;
                content: "";
                height: 8px;
                width: 8px;
                left: 4px;
                bottom: 4px;
                background-color: white;
                -webkit-transition: .4s;
                transition: .4s;
            }

        input:checked + .slider {
            background-color: #111e33;
        }

        input:focus + .slider {
            box-shadow: 0 0 1px #007dc6;
        }

        input:checked + .slider:before {
            -webkit-transform: translateX(26px);
            -ms-transform: translateX(26px);
            transform: translateX(26px);
            background-color: white;
        }

        /* Rounded sliders */
        .slider.round {
            border-radius: 34px;
        }

            .slider.round:before {
                border-radius: 50%;
            }

        .button {
            background-color: #4CAF50; /* Green */
            border: none;
            color: white;
            padding: 16px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            -webkit-transition-duration: 0.4s; /* Safari */
            transition-duration: 0.4s;
            cursor: pointer;
        }

        .button1 {
            background-color: white;
            color: black;
            border: 2px solid #4CAF50;
        }

            .button1:hover {
                background-color: #4CAF50;
                color: white;
            }

        .button2 {
            background-color: white;
            color: black;
            border: 2px solid #008CBA;
        }

            .button2:hover {
                background-color: #008CBA;
                color: white;
            }

        .button3 {
            background-color: white;
            color: black;
            border: 2px solid #f44336;
        }

            .button3:hover {
                background-color: #f44336;
                color: white;
            }

        .button4 {
            background-color: white;
            color: black;
            border: 2px solid #e7e7e7;
        }

            .button4:hover {
                background-color: #e7e7e7;
            }

        .button5 {
            background-color: white;
            color: #111e33;
            border: 2px solid #111e33;
        }

            .button5:hover {
                background-color: #111e33;
                color: white;
                box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="w3-container w3-center w3-animate-top" style="background-color: #111e33; min-height: 100vh; margin-left: -15px; margin-right: -15px">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container">
            <div class="jumbotron" style="opacity: .9">
                <div>

                    <div class="w3-container w3-center w3-animate-left">
                        <h1 style="color: #2f4f4f">Find Your Dream Job Here</h1>
                    </div>
                    <div class="w3-container w3-center w3-animate-right">
                        <h2 style="color: #2f4f4f">Be a jobseeker or a jobprovider <a href="ChooseJobProvider.aspx" target="_blank" style="color: #3b5998">Register</a> to get started</h2>
                    </div>

                </div>
                <div class="w3-container w3-center w3-animate-bottom">
                    <br />
                    <p><a href="JobList.aspx" class="btn button button5">Find Job</a></p>
                </div>
                <div class="w3-container w3-center w3-animate-top">
                    <br />
                    <p><a href="JobList.aspx" class="btn button button5">Hire People</a></p>
                </div>
            </div>
        </div>
        <div style="opacity: 0.9; background-color: #cccccc; filter: alpha(opacity=10); margin-left: -15px; margin-right: -15px">
            <br />
            <br />
            <div class="container">


                <div class="row">

                    <div style="background-color: white" class="panel panel-default">

                        <div style="background-color: #111e33; -webkit-border-radius: 10px" class="panel-heading">

                            <h2 align="center" style="color: white"><strong>Choose Your Categories</strong></h2>

                        </div>
                        <div class="row panel-body">

                            <div class="col-md-4">

                                <div></div>

                                <a id="AllButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="AllButtonClick();">
                                    <span class="glyphicon glyphicon-th-list"></span>&nbsp;&nbsp;<b>All</b>
                                </a>

                                <a id="HouseTutorButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="HouseTutorButtonClick();">
                                    <span class="glyphicon glyphicon-home"></span>&nbsp;&nbsp;<b>House Tutor</b>
                                </a>

                                <a id="DataEntryButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="DataEntryButtonClick();">
                                    <span class="glyphicon glyphicon-plus"></span>&nbsp;&nbsp;<b>Data Entry</b>
                                </a>


                                <a id="EventManagerButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="EventManagerButtonClick();">
                                    <span class="glyphicon glyphicon-calendar"></span>&nbsp;&nbsp;<b>Event Manager</b>
                                </a>


                                <a id="PhotographerButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="PhotographerButtonClick();">
                                    <span class="glyphicon glyphicon-camera"></span>&nbsp;&nbsp;<b>Photographer</b>
                                </a>


                                <a id="GraphicsDesignButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="GraphicsDesignButtonClick();">
                                    <span class="glyphicon glyphicon-blackboard"></span>&nbsp;&nbsp;<b>Graphics Design</b>
                                </a>


                                <a id="TransporterButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="TransporterButtonClick();">
                                    <span class="glyphicon glyphicon-plane"></span>&nbsp;&nbsp;<b>Transporter</b>
                                </a>


                                <a id="AdditionalDirectorButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="AdditionalDirectorButtonClick();">
                                    <span class="glyphicon glyphicon-film"></span>&nbsp;&nbsp;<b>Additional Director</b>
                                </a>

                                <a id="ConsultantButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="ConsultantButtonClick();">
                                    <span class="glyphicon glyphicon-retweet"></span>&nbsp;&nbsp;<b>Consultant</b>
                                </a>

                                <a id="WebDesignButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick="WebDesignButtonClick();">
                                    <span class="glyphicon glyphicon-globe"></span>&nbsp;&nbsp;<b>Web Design</b>
                                </a>
                                <a id="" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick=""></a>

                                <a id="" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #111e33; color: white" onclick=""></a>


                            </div>

                            <%--                     style="border-bottom: 3px solid #007dc6; -webkit-border-radius: 3px"--%>

                            <div class="col-md-8">

                                <div class="col-md-12">
                                    <div id="headlineLabel" style="font-family: Berlin Sans FB; font-size: 35px; color: #111e33">
                                        All in One
                                    </div>
                                    <hr style="height: 3px; background-color: #111e33; -webkit-border-radius: 2px" />
                                </div>


                                <%--  <div class="scrollCustom">--%>

                                <div class="col-md-12">
                                <div class="scrollbar" id="style-1" style="text-align: left">
                                    <div class="force-overflow">

                                        <div id="houseTutor">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="play_5Checkbox" name="check1" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Class: Play-5
                
                                            </div>
                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="clas6_8Checkbox" name="check2" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Class: 6-8
                
                                            </div>
                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="class9_10Checkbox" name="check3" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Class: 9-10
                
                                            </div>
                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="class11_12Checkbox" name="check4" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Class: 11-12
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="physicsCheckbox" name="check5" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: Physics
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="mathCheckbox" name="check6" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: Math
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="banglaCheckbox" name="check7" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: Bangla
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="englishCheckbox" name="check8" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: English
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="chemistryCheckbox" name="check9" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: Chemistry
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="accountingCheckbox" name="check10" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: Accounting
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="ictCheckbox" name="check11" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Subject: ICT
                
                                            </div>


                                        </div>



                                        <div id="dataEntry">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="basicLevelCheckbox" name="check12" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Data Entry Level: Basic Level
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="secondaryLevelCheckbox" name="check13" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Data Entry Level: Secondary Level
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="higherLevelCheckbox" name="check14" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Data Entry Level: Higher Level
                
                                            </div>



                                        </div>




                                        <div id="eventManager">


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="corporateMeetingCheckbox" name="check15" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Event Manager Type: Corporate Meeting
                
                                            </div>



                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="familyEventCheckbox" name="check16" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Event Manager Type: Family Event
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="partyCheckbox" name="check17" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Event Manager Type: Party
                
                                            </div>



                                        </div>




                                        <div id="photographer">


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="portraitCheckbox" name="check18" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Photography Type: Portrait
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="partyPhotographyCheckbox" name="check19" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Photography Type: Party
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="familyPhotographyCheckbox" name="check20" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Photography Type: Family
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="institutionPhotographyCheckbox" name="check21" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Photography Type: Institution
                
                                            </div>


                                        </div>


                                        <div id="graphicsDesign">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="photoshopCheckbox" name="check22" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Software: Photoshop
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="illustratorCheckbox" name="check23" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Software: Illustrator
                
                                            </div>

                                        </div>


                                        <div id="transporter">


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="bothWayCheckbox" name="check24" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Transporter Type: Both Way
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="oneWayCheckbox" name="check25" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Transporter Type: One Way
                
                                            </div>


                                        </div>


                                        <div id="additionalDirector">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="filmCheckbox" name="check26" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Director Type: Film
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="shortFilmCheckbox" name="check27" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Director Type: Short Film
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="documentaryCheckbox" name="check28" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Director Type: Documentary
                
                                            </div>


                                        </div>



                                        <div id="consultant">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="businessTransformationCheckbox" name="check29" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Business Transformation
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="engineeringConsultantCheckbox" name="check30" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Engineering Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="educationalConsultantCheckbox" name="check31" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Educational Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="humanResourcesConsultantCheckbox" name="check32" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Human Resources (HR) Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="immigrationConsultantCheckbox" name="check33" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Immigration Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="internetConsultantCheckbox" name="check34" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Internet Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="informationTechnologyConsultantCheckbox" name="check35" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Information-Technology(IT) Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="interimManagersCheckbox" name="check36" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Interim Managers
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="marketingConsultantCheckbox" name="check37" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Marketing Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="processConsultantCheckbox" name="check38" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Process Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="publicRelationConsultantCheckbox" name="check39" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Public-relations(PR) Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="performanceConsultantCheckbox" name="check40" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Performance Consultants
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="salesConsultantCheckbox" name="check41" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Sales Consultants
                
                                            </div>


                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="strategyConsultantCheckbox" name="check42" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: Strategy Consultants
                
                                            </div>



                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="D3ConsultantCheckbox" name="check43" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Consultant Type: 3D Consultants
                
                                            </div>

                                        </div>


                                        <div id="webDesign">

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="staticCheckbox" name="check44" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Web Design Type: Static
                
                                            </div>

                                            <div style="font-family: Arial; font-size: 27px">
                                                <label class="switch">
                                                    <input type="checkbox" id="dynamicCheckbox" name="check45" runat="server" />
                                                    <span class="slider"></span>
                                                </label>
                                                &nbsp;Web Design Type: Dynamic
                
                                            </div>
                                            <hr style="height: 3px; background-color: #111e33; -webkit-border-radius: 2px" />
                                        </div>
                                    </div>
                                </div>
                                </div>







                                <%-- </div>--%>
                                <br />
                                <br />



                            </div>

                            <div class="col-md-5"></div>
                            <div class="col-md-5"></div>
                            <div class="col-md-2">

                                <br />
                                <%--<asp:Button ID="SendButton" runat="server" Text="Send" CssClass="btn btn-lg btn-primary" Font-Size="Large" OnClick="SendButton_OnClick"/>--%>
                            </div>

                        </div>



                    </div>

                </div>

            </div>
            <br />
        </div>

        <div style="opacity: .7">
            <br />
            <br />
            <h1 style="text-align: center; color: white">How it works??</h1>
            <br />
            <div class="row" style="color: white;">
                <div class="col-md-2"></div>
                <div class="col-md-2" style="border: 1px solid white; border-radius: 5px; margin-left: 10px">
                    <h2><span class="glyphicon glyphicon-search"></span>&nbsp;FIND JOB</h2>
                    <br />
                    <p>Post a job to tell us about your project. We'll quickly match you with the right freelancers.</p>
                </div>
                <div class="col-md-2" style="border: 1px solid white; border-radius: 5px; margin-left: 10px">
                    <h2><span class="glyphicon glyphicon-ok"></span>&nbsp;HIRE</h2>
                    <p>Browse profiles, reviews, and proposals then interview top candidates. Hire a favorite and begin your project.</p>
                </div>
                <div class="col-md-2" style="border: 1px solid white; border-radius: 5px; margin-left: 10px">
                    <h2><span class="glyphicon glyphicon-briefcase"></span>&nbsp;WORK</h2>
                    <p>
                        Use the Upwork platform to chat, share files, and collaborate from your desktop or on the go.<br />
                        <br />
                    </p>
                </div>
                <div class="col-md-2" style="border: 1px solid white; border-radius: 5px; margin-left: 10px">
                    <h2><span class="glyphicon glyphicon-usd"></span>&nbsp;PAY</h2>
                    <p>Invoicing and payments happen through Upwork. With Upwork Protection, only pay for work you authorize.</p>
                </div>
            </div>

            <br />
            <br />
        </div>
        <div style="background-color: #cccccc; margin-left: -15px; margin-right: -15px">
            <br />
            <br />
            <div class="container panel" style="padding-left: 50px;">

                <h1 style="color: #111e33;"><strong>Job List</strong></h1>
                <hr style="border: 1px solid; color: #111e33" />
                <div class="">
                    <div class="row">
                        <div class="col-md-2" style="background-color: #111e33; color: white; position: inherit; -webkit-border-radius: 3px;">
                            <div>
                                <br />
                                <strong>Customize Job List</strong>
                                <hr style="border: 1px solid" />
                                <asp:DropDownList ID="categoryDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="categoryDropDownList_SelectedIndexChanged">
                                    <asp:ListItem>Category</asp:ListItem>
                                    <asp:ListItem>web</asp:ListItem>
                                    <asp:ListItem>design</asp:ListItem>
                                    <asp:ListItem>nothing</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList ID="typeDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="typeDropDownList_SelectedIndexChanged">
                                    <asp:ListItem>Type</asp:ListItem>
                                    <asp:ListItem>Online</asp:ListItem>
                                    <asp:ListItem>Offline</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList ID="timeDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="timeDropDownList_SelectedIndexChanged">
                                    <asp:ListItem>Time</asp:ListItem>
                                    <asp:ListItem>/hour</asp:ListItem>
                                    <asp:ListItem>/day</asp:ListItem>
                                    <asp:ListItem>/week</asp:ListItem>
                                    <asp:ListItem>/month</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <br />
                            </div>
                        </div>
                        <div class="col-md-10" style="position: inherit; overflow: scroll; height: 500px;">
                            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                                <ItemTemplate>
                                    <div class="">
                                        <table class="table table-hover table-responsive table-striped" style="border: 5px; background-color: #dcdcdc; -webkit-border-radius: 5px;">
                                            <tr style="background-color: #dcdcdc">
                                                <td>
                                                    <h4>
                                                        <strong>Job Title : </strong><%#Eval("JobTitle")%><br />
                                                        <strong>Job Code : </strong><%#Eval("JobCode")%>
                                                    </h4>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Image ID="Image1" runat="server" Height="122px"
                                                        ImageUrl='<%#Eval("CoverPhoto")%>' Width="250px" CssClass="img-rounded" />

                                                </td>
                                                <td>
                                                    <p style="text-align: center">
                                                        <strong>Job Type :</strong> <%#Eval("Type")%>
                                                        <%#Eval("Location")%>
                                                        <br />
                                                        <strong>Category :</strong> <%#Eval("Category")%>
                                                    </p>

                                                </td>
                                                <td>
                                                    <p>
                                                        <strong>Payment : </strong><%#Eval("Payment")%><%#Eval("Per")%>
                                                        <br />
                                                        <strong>Deadline : </strong><%#Eval("DeadLineDate")%>
                                                        <br />
                                                        <asp:LinkButton Text="Details" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' runat="server" />

                                                    </p>
                                                </td>
                                            </tr>
                                            <%--<tr>
                                    <td>Minimum Bid : <%#Eval("Type")%>
                                         <%#Eval("Location")%>
                                    </td>
                                </tr>--%>
                                            <tr style="background-color: #dcdcdc">
                                                <td>
                                                    <asp:LinkButton Text="Apply" CssClass="btn button5" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                                </td>
                                            </tr>

                                        </table>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
        <div style="background-color: #111e33; margin-left: -15px; margin-right: -15px; color: white">
            <br />
            <br />
            <p>
                Upwork was formed 18 months after Elance and oDesk announced their merger on December 18, 2013 to create Elance-oDesk.[13] oDesk was founded in 2003[14] by Odysseas Tsatalos and Stratis Karamanlakis.[15] Elance was founded in 1999 by Beerud Sheth and Srini Anumolu.[16] With the launch of Upwork,
                 the oDesk platform was upgraded and rebranded and the company announced that the Elance platform would be phased out within a couple of years, resulting in a single freelance marketplace.[17]

In early September 2015, the service experienced an outage which led to an apology being issued by CEO Stephane Kasriel.[18] This led to the introduction of an Upwork Status page to offer freelancers and clients greater transparency.[citation needed]

            </p>
            <br />
            <br />
        </div>
    </div>


    <script type="text/javascript">

        function AllButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            //headlineDivId.innerHTML = "<a><span class='glyphicon glyphicon-th-list'>&nbspAll</span></a>";
            headlineDivId.innerHTML = "All in One";

            houseTutorDivId.style.display = "block";
            dataEntryDivId.style.display = "block";
            eventManagerDivId.style.display = "block";
            photographerDivId.style.display = "block";
            graphicsDesignDivId.style.display = "block";
            transporterDivId.style.display = "block";
            additionalDirectorDivId.style.display = "block";
            consultantDivId.style.display = "block";
            webDesignDivId.style.display = "block";

        }


        function HouseTutorButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "House Tutor";

            houseTutorDivId.style.display = "block";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }

        function DataEntryButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Data Entry";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "block";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }


        function EventManagerButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Event Manager";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "block";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }



        function PhotographerButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Photographer";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "block";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }



        function GraphicsDesignButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Graphics Design";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "block";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }



        function TransporterButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Transporter";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "block";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }





        function AdditionalDirectorButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Additional Director";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "block";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "none";

        }



        function ConsultantButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Consultant";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "block";
            webDesignDivId.style.display = "none";

        }



        function WebDesignButtonClick() {

            var headlineDivId = document.getElementById("headlineLabel");
            var houseTutorDivId = document.getElementById("houseTutor");
            var dataEntryDivId = document.getElementById("dataEntry");
            var eventManagerDivId = document.getElementById("eventManager");
            var photographerDivId = document.getElementById("photographer");
            var graphicsDesignDivId = document.getElementById("graphicsDesign");
            var transporterDivId = document.getElementById("transporter");
            var additionalDirectorDivId = document.getElementById("additionalDirector");
            var consultantDivId = document.getElementById("consultant");
            var webDesignDivId = document.getElementById("webDesign");

            headlineDivId.innerHTML = "Web Design";

            houseTutorDivId.style.display = "none";
            dataEntryDivId.style.display = "none";
            eventManagerDivId.style.display = "none";
            photographerDivId.style.display = "none";
            graphicsDesignDivId.style.display = "none";
            transporterDivId.style.display = "none";
            additionalDirectorDivId.style.display = "none";
            consultantDivId.style.display = "none";
            webDesignDivId.style.display = "block";

        }


    </script>

</asp:Content>
