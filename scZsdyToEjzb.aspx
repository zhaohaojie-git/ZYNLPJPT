﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scZsdyToEjzb.aspx.cs" Inherits="ZYNLPJPT.scZsdyToEjzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除知识对应二级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
     <script type="text/javascript">
         function deleteZsdyToEjzb(zslybh, zsdybh) {
             $.post("processAspx/DelZsdyToEjzb.aspx", { 'zslybh': zslybh, 'zsdybh': zsdybh }, function (result) {
                 if (result == 'False') {
                     $.messager.alert('信息', '删除失败,请重试!', 'info', function () {
                         window.location.reload();
                     });
                 } else if (result == 'True') {
                     window.location.reload();
                 }
             });
         }
    </script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看知识单元" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'zslybh',align:'center'" width="8">知识领域编号</th>
    			<th data-options="field:'zslymc',align:'center'" width="15">知识领域名称</th>
                <th data-options="field:'zsdybh',align:'center'" width="8">知识单元编号</th>
    			<th data-options="field:'zsdymc',align:'center'" width="15">知识单元名称</th>
                <th data-options="field:'ejzbbh',align:'center'" width="8">对应二级指标编号</th>
    			<th data-options="field:'ejzbmc',align:'center'" width="15">对应二级指标名称</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
                <th data-options="field:'scButton',align:'center'" width="20">删除知识对应指标记录</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.zsnlViewWrappers.Length; i++)
                   {
                       Response.Write("<tr>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSLYBH + "</td>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSLYMC + "</td>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSDYBH + "</td>");
                       Response.Write("  <td >" + zsnlViewWrappers[i].ZsnlView.ZSDYMC + "</td>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].Ejzbbh + "</td>");
                       Response.Write("  <td >" + zsnlViewWrappers[i].Ejzbmc + "</td>");
                       Response.Write("  <td >" + zsnlViewWrappers[i].Xkmc + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\" deleteZsdyToEjzb(" + zsnlViewWrappers[i].ZsnlView.ZSLYBH + "," + zsnlViewWrappers[i].ZsnlView.ZSDYBH + ") \" >删除知识对应指标记录</a></td>");
                       Response.Write("</tr>");
                   }
                   %>
    	</tbody>
   	</table>     
</div>                
<script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            pagination: false,
            pageList: [30],
            pageSize: 30,
            singleSelect: true,
        });
    });
</script>
</body>
</html>
