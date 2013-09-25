<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="in.aspx.cs" Inherits="laos_project._in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <div class="row" style="display:block;float:right;margin-bottom: 10px;">                         
                        <a href="in.aspx" ><div class="btn btch cr">phoneme </div></a>
                        <a href="th.aspx" ><div class="btn btch">thai</div></a>
                    </div>
                <textarea id="input" runat="server" class="ta" ></textarea> 
                <asp:Button ID="Button1" runat="server" class="btn btn-primary bt-tran" 
                   Text="translate" onclick="Button1_Click" />  
                <textarea id="output" runat="server" readonly class="ta" ></textarea>  
</asp:Content>
