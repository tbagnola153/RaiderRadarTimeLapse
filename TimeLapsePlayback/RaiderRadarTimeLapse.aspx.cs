using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divTest.InnerHtml = "<img id=\"play\" class=\"mySlides\" src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/play.jpg\" style=\"width:100%\" onclick=\"carouselWithLabels(); playSong(); \">";
        testGetImagesWithLabels();
    }

    private void getImages()
    {
        string htmlBefore = "<img class=\"mySlides\" src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/";
        string htmlAfter = ".jpg\" style=\"width:100%\">";

        DateTime today = DateTime.Now;
        DateTime yesterday = today.AddDays(-1);

        string year = yesterday.Year.ToString();
        string month = yesterday.Month.ToString();
        string day = yesterday.Day.ToString();

        string file = year + "_" + month + "_" + day + "_";

        for (int hour = 0; hour < 24; hour++)
        {
            for (int min = 0; min < 60; min++)
            {
                string time = hour + "_" + min;
                divTest.InnerHtml = divTest.InnerHtml + htmlBefore + file + time + htmlAfter;
            }
        }

    }

    private void testGetImages()
    {
        string htmlBefore = "<img class=\"mySlides\" src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/";
        string htmlAfter = ".jpg\" style=\"width:100%\">";

        string year = "2016";
        string month = "3";
        string day = "30";

        string file = year + "_" + month + "_" + day + "_";

        for (int hour = 11; hour < 19; hour++)
        {
            for (int min = 0; min < 60; min++)
            {
                string time = hour + "_" + min;
                divTest.InnerHtml = divTest.InnerHtml + htmlBefore + file + time + htmlAfter;
            }
        }

    }

    private void testGetImagesWithLabels()
    {
        string firstdiv = "<div class=\"w3-display-container mySlides\">";
        string middlePreFileName = "<img src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/";
        // string fileName = "";
        string middlePostFileName = ".jpg\" style=\"width: 100%\">";
        string secondDiv = "<div class=\"w3-display-bottomleft w3-large w3-container w3-padding-16 w3-black\">";
        // string label = "";
        string closeDivs = "</div></div>";

        string year = "2016";
        string month = "4";
        string day = "2";

        string file = year + "_" + month + "_" + day + "_";

        for (int hour = 0; hour < 24; hour++)
        {
            for (int min = 0; min < 60; min++)
            {
                string time = hour + "_" + min;
                if(min < 10)
                {
                    divTest.InnerHtml = divTest.InnerHtml + firstdiv + middlePreFileName + file + time + middlePostFileName + secondDiv + month + "/" + day + "/" + year + " at " + hour + ":0" + min + closeDivs;
                }
                else
                {
                    divTest.InnerHtml = divTest.InnerHtml + firstdiv + middlePreFileName + file + time + middlePostFileName + secondDiv + month + "/" + day + "/" + year + " at " + hour + ":" + min + closeDivs;
                }
                
            }
        }

        for (int i = 0; i < 200; i++)
        {
            divTest.InnerHtml = divTest.InnerHtml + "<img class=\"mySlides\" src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/pressRelease.jpg\" style =\"width:500px\">";
        }

    }

    private void getImagesWithLabels()
    {
        string firstdiv = "<div class=\"w3-display-container mySlides\">";
        string middlePreFileName = "<img src=\"http://raider.mountunion.edu/~bagnolta/RaiderRadar/";
        // string fileName = "";
        string middlePostFileName = ".jpg\" style=\"width: 100%\">";
        string secondDiv = "<div class=\"w3-display-bottomleft w3-large w3-container w3-padding-16 w3-black\">";
        // string label = "";
        string closeDivs = "</div></div>";

        DateTime today = DateTime.Now;
        DateTime yesterday = today.AddDays(-1);

        string year = yesterday.Year.ToString();
        string month = yesterday.Month.ToString();
        string day = yesterday.Day.ToString();

        string file = year + "_" + month + "_" + day + "_";

        for (int hour = 0; hour < 24; hour++)
        {
            for (int min = 0; min < 60; min++)
            {
                string time = hour + "_" + min;
                if (min < 10)
                {
                    divTest.InnerHtml = divTest.InnerHtml + firstdiv + middlePreFileName + file + time + middlePostFileName + secondDiv + month + "/" + day + "/" + year + " at " + hour + ":0" + min + closeDivs;
                }
                else
                {
                    divTest.InnerHtml = divTest.InnerHtml + firstdiv + middlePreFileName + file + time + middlePostFileName + secondDiv + month + "/" + day + "/" + year + " at " + hour + ":" + min + closeDivs;
                }

            }
        }

    }

}