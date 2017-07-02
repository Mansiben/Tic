<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="Tic.TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic Tac Toe</title>
    <link href="Home.css" type="text/css" rel="stylesheet" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
  
        <h1><b>Tic Tac Toe</b></h1>
        <div class="MainContent">
            <div class="AllButtons">
                <asp:Button ID="Play_Game" runat="server" Text="Play Game" OnClick="PlayGame" /> 
                <br /><br />
                <asp:Button ID="Button_Reset" runat="server" Text="Reset" OnClick="Reset_Event" Visible="False" /><br />
                <br />
                <asp:Button ID="T1" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T1_Click" Width="100px" Visible="False" />
                <asp:Button ID="T2" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T2_Click" Width="100px" Visible="False" />
                <asp:Button ID="T3" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T3_Click" Width="100px" Visible="False" />
                <br />
                <asp:Button ID="T4" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T4_Click" Width="100px" Visible="False" />
                <asp:Button ID="T5" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T5_Click" Width="100px" Visible="False" />
                <asp:Button ID="T6" runat="server" Text="=&quot; &quot;" Height="75px" OnClick="T6_Click" Width="100px" Visible="False" />
                <br />
                <asp:Button ID="T7" runat="server" Height="75px" OnClick="T7_Click" Text="=&quot; &quot;" Width="100px" Visible="False" />
                <asp:Button ID="T8" runat="server" Height="75px" OnClick="T8_Click" Text="=&quot; &quot;" Width="100px" Visible="False" />
                <asp:Button ID="T9" runat="server" Height="75px" OnClick="T9_Click" Text="=&quot; &quot;" Width="100px" Visible="False" />   
           </div>
            <div class="AllLabels">
                <aside>
                    <br />
                    <asp:Label ID="HighScore" runat="server" Text="New High Score" Visible="False"></asp:Label><br />
                    <asp:Label ID="name" runat="server" Text="Enter Your Name:" Visible="False"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_name" runat="server" Visible="False"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button_Add" runat="server" OnClick="Button_Add_Click" Text="Button" Visible="False" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label> <br />
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label><br />
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label><br />
                    <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label><br />
                </aside>
         </div>
        </div>
 </form>
</body>
</html>
