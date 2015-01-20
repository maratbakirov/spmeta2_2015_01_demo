Add-PSSnapin Microsoft.SharePoint.PowerShell

$url = 'http://sp131:82'

Remove-SPSite -Identity $url


New-SPSite -Url $url -Template 'STS#0' -Language 1033 -OwnerAlias 'DOMAIN\sp_admin'
