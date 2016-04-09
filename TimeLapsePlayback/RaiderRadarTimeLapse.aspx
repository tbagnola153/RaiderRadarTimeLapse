<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RaiderRadarTimeLapse.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<title>Mount Union Time Lapse</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="stylesheet.css">
<style>
    .mySlides {
        display: none;
    }
</style>
<body onload="hidePleaseWait(); hideAllImagesExceptPlay();">
    <div id="divPleaseWait" runat="server">
        <label>Please wait...</label>
    </div>

    <div id="divTest" class="w3-content w3-section" style="width:100%; height:100%; max-width: 750px" runat="server">
    </div>

    <h3 id="hTitle" align="center"></h3>
    <h4 id="hArtist" align="center"></h4>
    <h5 id="hPerformedBy" align="center"></h5>

    <script>
        var myIndex = 0;
        
        var song = Math.floor(Math.random() * 2);;
        var duration = 100;

        function playSong() {
            var title = document.getElementById("hTitle");
            var artist = document.getElementById("hArtist");
            var performedBy = document.getElementById("hPerformedBy");
            if (song == 0) {
                title.innerHTML = "On Mount";
                //artist.innerHTML = "By The University of Mount Union";
                performedBy.innerHTML = "Performed by the University of Mount Union Band";
                duration = 18;
                new Audio('http://raider.mountunion.edu/~bagnolta/RaiderRadarMusic/OnMount.mp3').play();
            }
            if (song == 1) {
                title.innerHTML = "The University of Mount Union Alma Mater";
                //artist.innerHTML = "By The University of Mount Union";
                performedBy.innerHTML = "Performed by the University of Mount Union Steel Drum Ensemble - 2015";
                duration = 89;
                new Audio('http://raider.mountunion.edu/~bagnolta/RaiderRadarMusic/MenOfHarlech.mp3').play();
            }
        }
        

        function carouselWithLabels() {
            var i;
            var x = document.getElementsByClassName("mySlides");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            myIndex++;
            if (myIndex > x.length) {
                document.getElementById("hTitle").innerHTML = "";
                document.getElementById("hArtist").innerHTML = "";
                document.getElementById("hPerformedBy").innerHTML = "";
                hideAllImagesExceptPlay();
                song++;
                if (song == 2) {
                    song = 0;
                }
                return;
            }
            x[myIndex - 1].style.display = "block";
            setTimeout(carouselWithLabels, duration);
        }

        function hideAllImagesExceptPlay() {
            var i;
            var x = document.getElementsByClassName("mySlides");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            var p = document.getElementById("play");
            p.style.display = "block";
            myIndex = 0;
        }

        function hidePleaseWait() {
            var w = document.getElementById("divPleaseWait");
            w.hidden = true;
        }

    </script>

</body>
</html>