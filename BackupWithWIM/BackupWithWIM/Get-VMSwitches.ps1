Param([string]$username, [string]$password, [string]$hostName)

$secpasswd = ConvertTo-SecureString $password -AsPlainText -Force
$creds = New-Object System.Management.Automation.PSCredential ($username, $secpasswd)

$vmSwitches = Invoke-Command -ComputerName $hostName -Credential $creds -ScriptBlock {Get-VMSwitch} 


$vmSwitches = $vmSwitches.name

return $vmSwitches

