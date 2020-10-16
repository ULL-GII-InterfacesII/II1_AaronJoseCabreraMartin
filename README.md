# **Intefaces Inteligentes**
## Primera Práctica: Introducción a Unity
#####    *AaronJoseCabreraMartin*
---
#
##### **1. Importación de las StandardAssets y RPG Poly Pack Lite**
#
Para realizar la práctica, primero he ido a la sección de *"Asset Store"* para descargar las StandardAssets y el paquete RPG Poly Pack Lite. 

Las StandardAssets contienen algunos modelos, prefabs y comportamientos que nos ayudarán a la hora de construir proyectos y el paquete RPG Poly Pack Lite contiene bastantes modelos como casas, carretas, etc de estilo medieval, estos modelos los podemos utilizar fácilmente en nuestros proyectos y están bastante detallados.

![importar Standard Assets](https://user-images.githubusercontent.com/55997578/96301520-3a05ef80-0fef-11eb-8082-9ceeb7726572.png)
![importar RPG Poly Pack Lite](https://user-images.githubusercontent.com/55997578/96301677-6cafe800-0fef-11eb-809f-f1c9a11abf80.png)

Una vez descargados los paquetes debemos darle en el botón ***"IMPORT"*** para incluirlos en el proyecto.
#
##### **2. Creación de los objetos 3D**
#
Primero he creado el cubo, la capsula y el plano.
1. Click en el botón +
2. 3D models
3. Cube / Capsule / Terrain

![importar RPG Poly Pack Lite](https://user-images.githubusercontent.com/55997578/96301677-6cafe800-0fef-11eb-809f-f1c9a11abf80.png)

Luego, he creado la segunda luz.
1. Click en el botón +
2. Light
3. Direcctional Light

Y por último, el personaje Ethan de las standard assets y el modelo de una casa del RPG Poly Pack Lite.

1. En la parte inferior en el directorio de Assets.
2. Standard Assets, Characters, ThirdPersonCharacter, Models y ahí tendremos el modelo de Ethan. 
3. Para incluirlo en el poyecto basta tan solo con arrastrarlo a la vista del juego o a la lista de objetos 3D.
4. Para la casa del otro paquete en la misma pestaña, Assets, RPGPP_LT, models, estructures.

![importando a Ethan](https://user-images.githubusercontent.com/55997578/96301968-df20c800-0fef-11eb-907b-3563d6b1019b.png)
![importando modelo de RPGPPLT](https://user-images.githubusercontent.com/55997578/96302038-f8297900-0fef-11eb-87e8-941a868fe186.png)


Destacar que he utilizado una combinación de arrastrar los elementos desde la vista del juego para posicionar los elementos y con el inspector ajustar las coordenadas de los objetos. También he añadido algunos árboles para decorar la escena y le he dado textura de césped al terreno y forma de montañas a lo lejos. 
![Captura de pantalla (59)](https://user-images.githubusercontent.com/55997578/96302618-062bc980-0ff1-11eb-9940-55c399e81983.png)
#
##### **3. Programación de los scripts**
Para crear un script, nos situaremos en la carpeta de assets del proyecto y crearemos una carpeta script para tenerlos organizados, desde ahí click derecho, create, script C#. Con un doble click se nos abrirá el editor que teníamos como predeterminado en el Unity. 
En la práctica se nos pide crear scripts para todos los objetos, asignarle un valor identificativo a cada uno y un contador. Estos serán atributos de la clase que define el script, ambos se inicializarán en el método start. El contador debe actualizarse en el update y además debe mostrase por pantalla tanto el id como el contador.
Como todos los scripts son prácticamente iguales mostraré uno.
![script](https://user-images.githubusercontent.com/55997578/96302397-a59c8c80-0ff0-11eb-943b-0b9c11c1b003.png)

##### **4. Resultado Final**
En este GIF podemos observar los mensajes por consola.
![Webp net-gifmaker](https://user-images.githubusercontent.com/55997578/96302984-923df100-0ff1-11eb-8e33-06cc8f79791e.gif)

En este otro GIF podemos observar el resultado final
![output_w7Qy3K](https://user-images.githubusercontent.com/55997578/96303203-eea11080-0ff1-11eb-8f69-de282d950ea1.gif)


