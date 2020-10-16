---
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
Module Name: PnP.PowerShell
online version: https://docs.microsoft.com/powershell/module/sharepoint-pnp/update-pnpusertype
schema: 2.0.0
title: Update-PnPUserType
---

# Update-PnPUserType

## SYNOPSIS
Updates an available app from the app catalog

## SYNTAX

```powershell
Update-PnPUserType -LoginName <String>
```

## DESCRIPTION

This cmdlet retrieves the UserType value of the specified user and updates the UserType across all SharePoint Online sites in the SharePoint Online tenant. This can be used, for example, to convert a Guest user to a standard (Member) user if the user's UserType was previously updated in Azure AD.

## EXAMPLES

### EXAMPLE 1
```powershell
Update-PnPUserType -LoginName jdoe@contoso.com
```
Updates the jdoe@contoso.com's UserType on all SharePoint Online sites in the tenant based on the UserType value in Azure AD.

## PARAMETERS

### -LoginName
The login name of the target user to update across SharePoint Online.

```yaml
Type: String
Parameter Sets: (All)

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## RELATED LINKS

[Microsoft 365 Patterns and Practices](https://aka.ms/m365pnp)