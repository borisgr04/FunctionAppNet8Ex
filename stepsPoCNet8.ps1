.\az_active_subscription_test.ps1

.\createFunction.ps1 -ResourceGroupName 'rg-function-2024' -StorageAccountName 'sa-function-2024' -FunctionAppName 'FnWebHook-N8-2024' -Location 'westus'

az functionapp delete --name 'FnWebHook-N8-2024' resource-group 'rg-function-2024'

func azure functionapp publish 'FnWebHook-N8-2024'

func azure functionapp publish 'FnWebHook-N8-2024' --csx FunctionAppNet8Ex.csproj

##.\PublishFnWebHook.ps1

##.\createAPIM.ps1 -ResourceGroupName 'rg-function-2024' -ApiManagementName 'apim-function-2024' -PublisherEmail 'boris.gonzalez@softwareone.com' -Location 'westus'

#.\connectApimToFunction.ps1 -ResourceGroupName 'rg-function-2024' -ApiManagementName 'apim-function-2024' -FunctionAppName 'FnWebHook-2024' -ApiManagementPolicyPath 'C:\SCEcpTrue\PocAzFunctionApiM\MyFunctionApp\policy.xml'

##.\importFunctionToApim.ps1 -ResourceGroupName 'rg-function-2024' -ApiManagementName 'apim-function-2024' -FunctionAppName 'FnWebHook-2024' -ApiManagementPolicyPath 'C:\SCEcpTrue\PocAzFunctionApiM\MyFunctionApp\policy.xml' -ApimApiPath 'WebHook' -ApimApiDisplayName 'Kaleido-WebHook'  



