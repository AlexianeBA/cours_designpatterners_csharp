1.Quel pattern de conception permettrait de créer efficacement 
de nouveaux contrats en évitant de recréer entièrement 
chaque contrat à partir de zéro ?

=> Le pattern de conception Prototype

4.Comment votre solution permettrait-elle de gérer efficacement :
    - La création de multiples versions d'un même contrat
    - L'ajout d'un nouveau type de contrat
    - La modification des clauses standard

Il est facilement possible de cloner un contrat existant 
et d'apporter des modifications à la copie sans affecter l'original.

Pour ajouter un nouveau type de contrat il faut créer une nouvelle
classe qui hérite de Contrat assurance et qui implémente la méthode 
Colne.

Les clauses standard sont stockées dans la liste de chaque
contrat.
Il est donc facile de modifier cette liste pour mettre à jour
les clauses standard d'un contrat spécifique ou d'un prototype.
