<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trainers.aspx.cs" Inherits="aspmuser.Trainers.Trainers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="TrainerAdmin.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet"/>
<link href="recent-news-boxes.css" rel="stylesheet"/>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 194px;
        }
    </style>
</head>
<body>
   <style>
body {
    background-repeat: no-repeat;
    background-size: cover;
    background-image: url('../Color_OlympicGames.png');

}
</style>


<div class="topnav" runat="server">
<%--  <a class="active" href="#home">Home</a>--%>
  <a class="active" href="Event_Admin.aspx"><i class="fa fa-fw fa-home"></i> Home</a>
  <a href="#about">About</a>
   <a href="#"><i class="fa fa-fw fa-envelope"></i> Contact</a>
  <a href="#4"></a>
  <a href="#5"></a>
  <a href="#6"></a>
  <a href="Trainers_List.aspx">Show</a>
  <a href="Trainer_AddNewTrainer.aspx">Create</a>
  <a href="Trainers_FindTrainer.aspx"><i class="fa fa-fw fa-search"></i>Find</a>
  <a href="Trainers_UpdateTrainer.aspx">Update</a>


</div>

    <form id="form1" runat="server">
        <div>
<section class="recentNews">
  <div class="container">
    <h2 class="news-title">Recent News</h2>
    <div class="row">
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://www.3pillarglobal.com/news/3pillar-global-named-among-inc-5000-fastest-growing-companies-for-9th-time/"><img alt="News Entry" src="../Photos/BackgroundPage.png"></a>
          </div>
          <div  href="https://www.w3schools.com/" class="ct-blog-content">
            <div class="ct-blog-date">
              <span>December</span><strong>19</strong>
            </div>
            <h3 href="https://www.w3schools.com/" class="ct-blog-header">
              Official news source for the Beijing 2022 Winter Olympic Games
            </h3>
          </div>
        </div>
      </div>
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://www.nbcnews.com/news/olympics/tokyo-olympics-closing-ceremony-set-bring-imperfect-irrepressible-games-end-n1276009"><img alt="News Entry" src="../Photos/Tokyo.png"</a>
          </div>
          <div class="ct-blog-content">
            <div class="ct-blog-date">
              <span>December</span><strong>17</strong>
            </div>
            <h3 class="ct-blog-header">
            Tokyo staged an Olympiad that was delayed by Covid 
            </h3>
          </div>
        </div>
      </div>
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://olympics.com/en/news/angelina-melnikova-rio-disappointment-tokyo-greatness-interview"><img alt="News Entry"  src="../Photos/Angelina.png" />></a>
          </div>
          <div class="ct-blog-content">
            <div class="ct-blog-date">
              <span>December</span><strong>16</strong>
            </div>
            <h3 class="ct-blog-header">
              After Rio disappointment, Angelina Melnikova thought 
                "I'm not going to be a great athlete."
            </h3>
          </div>
        </div>
      </div>
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://www.nbcnews.com/news/olympics/team-usa-dominates-brazil-clinch-first-women-s-volleyball-gold-n1276288"><img alt="News Entry" src="../Photos/TeamsUSA.png"></a>
          </div>
          <div class="ct-blog-content">
            <div class="ct-blog-date">
              <span>February</span><strong>23</strong>
            </div>
            <h3 class="ct-blog-header">
              Team USA dominates Brazil to clinch first women's volleyball gold
            </h3>
          </div>
        </div>
      </div>
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://www.nbcnews.com/news/olympics/allyson-felix-becomes-most-decorated-american-track-athlete-all-time-n1276252"><img alt="News Entry" src="../Photos/AlysonFelix.png"></a>
          </div>
          <div class="ct-blog-content">
            <div class="ct-blog-date">
              <span>February</span><strong>20</strong>
            </div>
            <h3 class="ct-blog-header">
              Allyson Felix becomes most decorated American track athlete in Olympic history
            </h3>
          </div>
        </div>
      </div>
      <div class="ct-blog col-sm-6 col-md-4">
        <div class="inner">
          <div class="fauxcrop">
            <a href="https://www.aljazeera.com/sports/2021/12/19/china-tennis-star-peng-denies-making-accusation-of-sexual-assault"><img alt="News Entry" src="../Photos/PengShui.png"></a>
          </div>
          <div class="ct-blog-content">
            <div class="ct-blog-date">
              <span>February</span><strong>16</strong>
            </div>
            <h3 class="ct-blog-header">
              WebCorpCo's Latest Release (CMS 8) Available Today
            </h3>
          </div>
        </div>
      </div>
    </div>
    <div class="btn-news btn-contests">
      <a href="#">VIEW ALL NEWS</a>
    </div>
  </div>
</section>
        </div>
    </form>
</body>
</html>
