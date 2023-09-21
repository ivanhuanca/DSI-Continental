<?php
include 'config.php';
if (isset($_POST['nombres'])) {
    $nombres = $_POST['nombres'];
    $apellidos = $_POST['apellidos'];
    $dni = $_POST['dni'];

    $sql = "INSERT into usuarios (nombres, apellidos, dni) VALUES ('$nombres', '$apellidos', '$dni')";

    if ($conexion->query($sql) === TRUE) {
        $mensaje = "Registro agregado correctamente.";
    } else {
        $mensaje = "Error al agregar el registro: " . $conexion->error;
    }
}

$sql = "SELECT * FROM usuarios ORDER BY id ASC";
$items = $conexion->query($sql);
?>
<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <title>Formulario - Nuevo usuario</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link href="./assets/css/styles.css" rel="stylesheet">
</head>

<body data-bs-theme="dark">
    <div class="container">
        <div class="row">
            <a href="./">
                <input role="button" value="Agregar" class="btn btn-success float-end">
            </a>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Nombres</th>
                        <th scope="col">Apellidos</th>
                        <th scope="col">DNI</th>
                    </tr>
                </thead>
                <tbody>
                    <?php while ($item = $items->fetch_assoc()) { ?>
                        <tr>
                            <th scope="row"><?= $item['id'] ?></th>
                            <td><?= $item['nombres'] ?></td>
                            <td><?= $item['apellidos'] ?></td>
                            <td><?= $item['dni'] ?></td>
                        </tr>
                    <?php } ?>
                </tbody>
            </table>
        </div>
    </div>
</body>

</html>