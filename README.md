# CONTROL-DE-INVENTARIO-DE-TECNOPUNTO

## Descripción del programa
Este programa fue desarrollado para ayudar a la tienda TecnoPunto a gestionar su inventario de productos de forma segura y organizada. El sistema permite registrar productos mediante objetos de la clase Producto, validando que los datos ingresados sean correctos antes de almacenarlos, cada producto puede calcular automáticamente su valor total en inventario multiplicando el precio por la cantidad disponible, reduciendo errores y facilitando el control de existencias.

## Datos de entrada
El usuario debe ingresar la siguiente información para cada producto:
Código del producto, nombre del producto, precio del producto y cantidad disponible.

El sistema valida que:
El nombre no esté vacío, el precio sea mayor que cero y la cantidad no sea negativa.

## Datos que procesa
El programa recibe los datos de cada producto y realiza validaciones para asegurar la integridad de la información. Posteriormente calcula el valor total del producto mediante la operación:
Valor Total = Precio × Cantidad

## Datos de salida
El programa muestra:
Código del producto, nombre del producto, precio unitario, cantidad disponible y el valor total en inventario.
Además muestra mensajes de error cuando se introducen datos inválidos.

# Captura 1: Datos Validos
<img width="375" height="850" alt="image" src="https://github.com/user-attachments/assets/3cc62b6f-cbfe-4a2f-a208-cac0f05a7426" />
En esta ejecución se observa el funcionamiento normal del programa. Los datos ingresados cumplen con todas las validaciones y el sistema calcula correctamente el valor total del producto utilizando el precio y la cantidad registrada.

# Captura 2: Precio Negativo
<img width="292" height="131" alt="image" src="https://github.com/user-attachments/assets/cc756622-ce11-4e8d-8c0a-1b89eaf5abad" />
Como se puede apreciar, aparece el mensaje de error ya que el precio es menor que cero.

# Captura 3: Nombre Vacío
<img width="267" height="131" alt="image" src="https://github.com/user-attachments/assets/061b6881-8c0a-471e-8382-08be22c4547d" />
Como se puede observar nuevamente, aparece el mensaje de que no puede estar vacio el nombre al detectar que lo dejamos vacio el apartado.

# Captura 4: Cantidad Cero
<img width="167" height="116" alt="image" src="https://github.com/user-attachments/assets/61da0534-d608-4747-9494-1608873f69b4" />
Como se puede ver, la cantidad cero sí se permite, porque el requisito nos dice que la cantidad no puede ser negativa, y cero no es negativo, entonces por eso la captura muestra que el producto se registra normalmente.
