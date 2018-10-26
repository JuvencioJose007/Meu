<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

<form action="CapturarDados.jsp" method="post">
	Nome: <input type="text" name="name" />
	<input type="submit" value="Enviar"/><br/>
</form>

<% 
String nome = request.getParameter("name");
if(nome != null && nome != "")
	out.print("Olá, "+nome);
%>

</body>
</html>