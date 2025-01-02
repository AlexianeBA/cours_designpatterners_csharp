1. Les méthode EnvoyerParEmail, EnvoyerParSMS, EnvoyerParPush sont dupliquées dans chaque classe (NotificationLivraison, NotificationSupport, NotificationCommande). Cela entraîne une duplication de code

Si on souhaite ajouter un nouveau type de notification cela nécessiterai de modifier chaque classe de notification pour ajouter la nouvelle méthode.

La ducplication du code rend la maintenance difficile. 
Toutes les modifications de la logique d'envoi de notification doit être répliquée dans chaque classe. Cela augmente les risques d'erreurs.

Les classes de notification sont fortement couplées aux types de notifications spécifiques. Cela rend difficile le changement ou l'ajout de nouveaux types de notifications sans modifier les classes existantes.

2. 