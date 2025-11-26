# Transacts Web Application

## Description

Application web complète qui reproduit exactement les fonctionnalités de l'application Windows Forms Transacts pour la gestion de plage/resort. L'application est entièrement compatible avec les smartphones et tablettes.

## Fonctionnalités

### Modules Principaux
- **Gestion Clients** - Ajout, modification, suppression et recherche de clients
- **Gestion Plage** - Gestion interactive des transats avec réservations
- **Restaurant** - Gestion des produits et menus restaurant
- **Bar** - Gestion des boissons et cocktails
- **Snack** - Gestion des produits snack
- **Boutique** - Gestion des articles boutique
- **Base Nautique** - Gestion des activités nautiques
- **Personnel** - Gestion des employés

### Caractéristiques Techniques
- **Responsive Design** - Compatible smartphones, tablettes et desktop
- **Interface Tactile** - Optimisée pour les écrans tactiles
- **Authentification** - Système de connexion sécurisé
- **Base de Données** - Entity Framework Core avec SQL Server
- **Temps Réel** - Mise à jour en temps réel des statuts

## Installation

### Prérequis
- .NET 8.0 SDK
- SQL Server ou SQL Server LocalDB
- Visual Studio 2022 ou VS Code

### Étapes d'installation

1. **Cloner le projet**
   ```bash
   cd web
   ```

2. **Restaurer les packages NuGet**
   ```bash
   dotnet restore
   ```

3. **Configurer la base de données**
   - Modifier la chaîne de connexion dans `appsettings.json`
   - Exécuter les migrations :
   ```bash
   dotnet ef database update
   ```

4. **Lancer l'application**
   ```bash
   dotnet run
   ```

5. **Accéder à l'application**
   - Ouvrir un navigateur et aller à `https://localhost:5001`
   - Se connecter avec : admin/admin

## Structure du Projet

```
web/
├── Controllers/          # Contrôleurs MVC
├── Models/              # Modèles de données
├── Views/               # Vues Razor
├── Data/                # Contexte Entity Framework
├── wwwroot/             # Fichiers statiques
│   ├── css/            # Styles CSS
│   ├── js/             # Scripts JavaScript
│   └── images/         # Images
└── appsettings.json    # Configuration
```

## Utilisation Mobile

### Interface Tactile
- **Transats** - Toucher pour sélectionner, double-tap pour actions
- **Navigation** - Menu hamburger sur mobile
- **Formulaires** - Champs optimisés pour saisie tactile
- **Tableaux** - Défilement horizontal automatique

### Fonctionnalités Mobiles
- **Géolocalisation** - Pour les services de livraison
- **Notifications Push** - Alertes en temps réel
- **Mode Hors-ligne** - Synchronisation automatique
- **Caméra** - Scan de codes-barres produits

## API Endpoints

### Clients
- `GET /Clients` - Liste des clients
- `POST /Clients/Create` - Créer un client
- `PUT /Clients/Edit/{id}` - Modifier un client
- `DELETE /Clients/Delete/{id}` - Supprimer un client

### Transats
- `GET /Transats` - Vue de la plage
- `POST /Transats/Reserve` - Réserver un transat
- `POST /Transats/CreateTransat` - Créer un transat
- `POST /Transats/UpdatePosition` - Déplacer un transat

### Produits
- `GET /Produits?type={type}` - Produits par type
- `POST /Produits/Create` - Créer un produit
- `POST /Produits/ToggleDisponibilite` - Changer disponibilité

## Sécurité

- **Authentification** - Cookie-based authentication
- **Autorisation** - Contrôle d'accès par rôle
- **CSRF Protection** - Protection contre les attaques CSRF
- **Validation** - Validation côté client et serveur
- **HTTPS** - Communication sécurisée

## Performance

- **Lazy Loading** - Chargement différé des données
- **Caching** - Mise en cache des données fréquentes
- **Compression** - Compression gzip des réponses
- **CDN** - Utilisation de CDN pour les ressources statiques

## Déploiement

### Azure App Service
```bash
dotnet publish -c Release
# Déployer sur Azure App Service
```

### Docker
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0
COPY . /app
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "TransactsWeb.dll"]
```

### IIS
- Publier en mode Release
- Configurer IIS avec ASP.NET Core Module
- Configurer la chaîne de connexion

## Support

Pour toute question ou problème :
- Consulter la documentation
- Vérifier les logs d'application
- Contacter l'équipe de développement

## Licence

© 2024 OxencoSofts. Tous droits réservés.