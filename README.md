# Formation API

Le but de ce repos est de permettre de s'entrainer sur des framework front et plus spécifiquement avec Typescript.

L'API est développé en ASP net core. 

Le projet utilise une base de données SQLite et est construit grâce à Entity Framework Core en Code First

>Commande utiles :

``` bash
# restaurer les packages nuget
dotnet restore

# build la solution
dotnet build

# lancer la solution
dotnet run

# Ajouter une migration dans un but de mettre à jour le schéma de la BDD
dotnet ef migrations add <Nom de la migration>

# Mettre à jour le schéma de la BDD
dotnet ef database update
``` 