<%@ Page Title="" Language="C#" MasterPageFile="~/PartialMasterPage.Master" AutoEventWireup="true" CodeBehind="CategoryRegisterForJobSeeker.aspx.cs" Inherits="UpWorkWeb.CategoryRegisterForJobSeeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
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
            background-color: #007dc6;
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
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container">


        <div class="row">

            <div style="background-color: white" class="panel panel-default">

                <div style="background-color: #007dc6; -webkit-border-radius: 10px" class="panel-heading">

                    <h2 align="center" style="color: white"><strong>Choose Your Categories</strong></h2>

                </div>
                <div class="row panel-body">

                    <div class="col-md-4">

                        <div></div>

                        <a id="AllButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="AllButtonClick();">
                            <span class="glyphicon glyphicon-th-list"></span>&nbsp;&nbsp;<b>All</b>
                        </a>

                        <a id="HouseTutorButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="HouseTutorButtonClick();">
                            <span class="glyphicon glyphicon-home"></span>&nbsp;&nbsp;<b>House Tutor</b>
                        </a>

                        <a id="DataEntryButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="DataEntryButtonClick();">
                            <span class="glyphicon glyphicon-plus"></span>&nbsp;&nbsp;<b>Data Entry</b>
                        </a>


                        <a id="EventManagerButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="EventManagerButtonClick();">
                            <span class="glyphicon glyphicon-calendar"></span>&nbsp;&nbsp;<b>Event Manager</b>
                        </a>


                        <a id="PhotographerButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="PhotographerButtonClick();">
                            <span class="glyphicon glyphicon-camera"></span>&nbsp;&nbsp;<b>Photographer</b>
                        </a>


                        <a id="GraphicsDesignButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="GraphicsDesignButtonClick();">
                            <span class="glyphicon glyphicon-blackboard"></span>&nbsp;&nbsp;<b>Graphics Design</b>
                        </a>


                        <a id="TransporterButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="TransporterButtonClick();">
                            <span class="glyphicon glyphicon-plane"></span>&nbsp;&nbsp;<b>Transporter</b>
                        </a>


                        <a id="AdditionalDirectorButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="AdditionalDirectorButtonClick();">
                            <span class="glyphicon glyphicon-film"></span>&nbsp;&nbsp;<b>Additional Director</b>
                        </a>

                        <a id="ConsultantButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="ConsultantButtonClick();">
                            <span class="glyphicon glyphicon-retweet"></span>&nbsp;&nbsp;<b>Consultant</b>
                        </a>

                        <a id="WebDesignButton" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick="WebDesignButtonClick();">
                            <span class="glyphicon glyphicon-globe"></span>&nbsp;&nbsp;<b>Web Design</b>
                        </a>
                        <a id="" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick=""></a>

                        <a id="" class="btnLeftAlign" style="font-size: 15px; width: 300px; height: 51px; background-color: #007dc6; color: white" onclick=""></a>


                    </div>

                    <%--                     style="border-bottom: 3px solid #007dc6; -webkit-border-radius: 3px"--%>

                    <div class="col-md-8">


                        <div id="headlineLabel" style="font-family: Berlin Sans FB; font-size: 35px; color: #007dc6">
                            All in One
                        </div>
                        <hr style="height: 3px; background-color: #007dc6; -webkit-border-radius: 2px" />

                        <%--  <div class="scrollCustom">--%>


                        <div class="scrollbar" id="style-5">
                            <div class="force-overflow">

                                <div id="houseTutor">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="play_5Checkbox" name="check1" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Class: Play-5
                
                                    </div>
                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="clas6_8Checkbox" name="check2" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Class: 6-8
                
                                    </div>
                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="class9_10Checkbox" name="check3" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Class: 9-10
                
                                    </div>
                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="class11_12Checkbox" name="check4" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Class: 11-12
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="physicsCheckbox" name="check5" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: Physics
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="mathCheckbox" name="check6" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: Math
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="banglaCheckbox" name="check7" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: Bangla
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="englishCheckbox" name="check8" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: English
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="chemistryCheckbox" name="check9" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: Chemistry
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="accountingCheckbox" name="check10" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: Accounting
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="ictCheckbox" name="check11" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Subject: ICT
                
                                    </div>


                                </div>



                                <div id="dataEntry">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="basicLevelCheckbox" name="check12" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Data Entry Level: Basic Level
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="secondaryLevelCheckbox" name="check13" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Data Entry Level: Secondary Level
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="higherLevelCheckbox" name="check14" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Data Entry Level: Higher Level
                
                                    </div>



                                </div>




                                <div id="eventManager">


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="corporateMeetingCheckbox" name="check15" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Event Manager Type: Corporate Meeting
                
                                    </div>



                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="familyEventCheckbox" name="check16" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Event Manager Type: Family Event
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="partyCheckbox" name="check17" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Event Manager Type: Party
                
                                    </div>



                                </div>




                                <div id="photographer">


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="portraitCheckbox" name="check18" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Photography Type: Portrait
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="partyPhotographyCheckbox" name="check19" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Photography Type: Party
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="familyPhotographyCheckbox" name="check20" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Photography Type: Family
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="institutionPhotographyCheckbox" name="check21" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Photography Type: Institution
                
                                    </div>


                                </div>


                                <div id="graphicsDesign">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="photoshopCheckbox" name="check22" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Software: Photoshop
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="illustratorCheckbox" name="check23" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Software: Illustrator
                
                                    </div>

                                </div>


                                <div id="transporter">


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="bothWayCheckbox" name="check24" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Transporter Type: Both Way
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="oneWayCheckbox" name="check25" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Transporter Type: One Way
                
                                    </div>


                                </div>


                                <div id="additionalDirector">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="filmCheckbox" name="check26" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Director Type: Film
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="shortFilmCheckbox" name="check27" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Director Type: Short Film
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="documentaryCheckbox" name="check28" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Director Type: Documentary
                
                                    </div>


                                </div>



                                <div id="consultant">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="businessTransformationCheckbox" name="check29" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Business Transformation
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="engineeringConsultantCheckbox" name="check30" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Engineering Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="educationalConsultantCheckbox" name="check31" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Educational Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="humanResourcesConsultantCheckbox" name="check32" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Human Resources (HR) Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="immigrationConsultantCheckbox" name="check33" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Immigration Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="internetConsultantCheckbox" name="check34" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Internet Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="informationTechnologyConsultantCheckbox" name="check35" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Information-Technology(IT) Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="interimManagersCheckbox" name="check36" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Interim Managers
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="marketingConsultantCheckbox" name="check37" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Marketing Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="processConsultantCheckbox" name="check38" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Process Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="publicRelationConsultantCheckbox" name="check39" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Public-relations(PR) Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="performanceConsultantCheckbox" name="check40" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Performance Consultants
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="salesConsultantCheckbox" name="check41" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Sales Consultants
                
                                    </div>


                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="strategyConsultantCheckbox" name="check42" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: Strategy Consultants
                
                                    </div>



                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="D3ConsultantCheckbox" name="check43" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Consultant Type: 3D Consultants
                
                                    </div>

                                </div>


                                <div id="webDesign">

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="staticCheckbox" name="check44" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Web Design Type: Static
                
                                    </div>

                                    <div style="font-family: Arial; font-size: 27px">
                                        <label class="switch">
                                            <input type="checkbox" id="dynamicCheckbox" name="check45" runat="server"/>
                                            <span class="slider"></span>
                                        </label>
                                        &nbsp;Web Design Type: Dynamic
                
                                    </div>
                                    <hr style="height: 3px; background-color: #007dc6; -webkit-border-radius: 2px" />
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
                        <asp:Button ID="SendButton" runat="server" Text="Send" CssClass="btn btn-lg btn-primary" Font-Size="Large" OnClick="SendButton_OnClick"/>
                    </div>

                </div>



            </div>

        </div>

    </div>

    


    <br />
    <br />
    <br />
    <br />




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
