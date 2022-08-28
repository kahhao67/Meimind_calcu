<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section>
            <div class="form-group divtopinfo mb-0">
                <div class="col-md-12">
                    <div class="col-md-12" id="divmessage" runat="server" visible="false">
                        <span style="color:red;">
                            <asp:Label ID="txtmessage" runat="server"></asp:Label>
                        </span>
                    </div>
                    <div class="row cards">
                        <div class="form-group col-md-12">
                            <label><%= GetGlobalResourceObject("resource", "Member_IC")%></label>
                            <div class="input-group">
                                <asp:TextBox ID="txtIC" placeholder="IC INPUT" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                                
                        <asp:Button ID="btnSubmit" Text="Submit" CssClass="btn" runat="server" OnClick="btnSubmit_Click"/>
                    </div>
                    <br />
                    <br />
                    <table>
                        <tbody>
                            <tr>
                                <th colspan="2">Answer</th>
                            </tr>
                           
                            <tr>
                                <td>IC:</td>
                                <td><asp:Label ID="IC_3" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>Name:</td>
                                <td><asp:Label ID="Name_3" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>Age:</td>
                                <td><asp:Label ID="Age_3" runat="server" /></td>
                            </tr>

                             <tr>
                                <th colspan="2">Thousand King Series</th>
                            </tr>
                            <tr>
                                <td>Combination King Series:</td>
                                <td><asp:Label ID="No_4" runat="server" /></td>
                            </tr>
                            <tr>
                                <th colspan="2">Hidden Aura of "0"</th>
                            </tr>   
                            <tr>
                                <td>Hidden Aure Value:</td>
                                <td><asp:Label ID="Value_1" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>IC:</td>
                                <td><asp:Label ID="Value_2" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>Name:</td>
                                <td><asp:Label ID="Value_3" runat="server" /></td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <br />

                </div>
            </div>
        </section>
</asp:Content>
