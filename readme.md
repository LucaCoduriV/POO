# Programmation Orientée Objet(POO)
## Introduction
Ce projet demandé par notre professeur du cours MA-24 a pour but de nous noter sur notre capacité à utiliser Github ainsi que notre capacité à se documenter afin de résoudre un problème auquel nous sommes confrontés.
Pour ce projet, j'ai choisi comme problématique, la programmation orientée objet(POO).

## Recherche d'informations :
Pour comprendre le fonctionnement de la programmation orientée objet, j'ai tout d'abord fait des recherches de site portant sur le sujet à l'aide de google.
J'ai donc pu trouver ce site: [OpenClassRoom](https://openclassrooms.com/fr/courses/2818931-programmez-en-oriente-objet-avec-c/2818971-la-poo-et-le-c)
Il ne m'a pas semblé été nécessaire de chercher d'autre site car je l'ai trouvé assez complet et facile de compréhension.

## L'apprentissage :
Pour ma part, j'apprends plus facilement en pratiquant. C'est pourquoi après chaque chapitre du site j'ai essayé de reproduire ce que j'avais lu pour vérifier si j'avais bien tout compris. Dans le cas contraire je relisais la partie encore floue jusqu'à tout comprendre.

## Mise en pratique :
Pour la mise en pratique j'ai eu de la chance de trouver un petit [TP](https://openclassrooms.com/fr/courses/2818931-programmez-en-oriente-objet-avec-c/2818991-tp-creez-un-petit-jeu-oriente-objet). J'ai pu de cette manière comprendre plus facilement l'utilité de la programmation orientée objet sans devoir m'inventer un exercice.

Le but de ce TP est de créer un joueur qui attaque plusieurs monstres. Mais le joueur peut se faire attaquer à son tour s'il rate son attaque contre le monstre. Chaque attaque de monstre réussit enlève des points de vie au joueur. En revanche chaque attaque du joueur sur un monstre réussit tue le monstre. Pour savoir si une attaque est réussie ou pas, le joueur et le monstre lancent un dé celui qui a le nombre le plus grand gagne. Pour augmenter la difficulté, un monstre qui inflige plus de dégâts aura une chance sur deux d’apparaître à la place d'un monstre normal. Le jeu s’arrête quand le joueur n'a plus de point de vie.

## Tests
Pour faire mes tests j'ai tout simplement utilisé la console. À chaque création de class j'essayais de faire certaines actions comme afficher les points de vie ou encore attaquer et avec l'aide de la console j'ai pu vérifier si les résultats étaient juste ou faux. Quand j'étais certain que mes class fonctionnait de la manière dont je voulais je suis passé au main. J'ai pu utiliser la même procédure pour tester mon code dans le main.

## Problème rencontré
J'ai pu grâce à mes tests me rendre compte que la création de plusieurs nombres aléatoires ne fonctionnait pas correctement, j'avais le même nombre à chaque appel. Pour corriger le problème, j'ai dû crée un seul objet de la class Random en static.

## Conclusion
J'ai trouvé ce projet très instructif car il m'a "forcé" à me renseigner sur un sujet pour lequel je ne trouvais pas forcément le temps ou l'envie de m'investir. La programmation orientée objet est très pratique, et j'ai pu me rendre compte dans le cas de ce TP que ça rend la tâche de création de monstre beaucoup plus simple et infini(ou presque). De plus je trouve le code beaucoup plus instinctif à l'écriture et lisible à la relecture car on décrit les actions d'un objet et ses caractéristiques.
