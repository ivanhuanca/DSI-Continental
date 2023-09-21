
<?php
$sever = "localhost";
$user = "root";
$pw = "";
$bd = "form";
$conexion = new mysqli($sever, $user, $pw, $bd);

if (!$conexion) {
    die("Error de conexión: " . $conn->connect_error);
}
?>