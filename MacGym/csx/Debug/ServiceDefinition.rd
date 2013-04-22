<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="MacGym" generation="1" functional="0" release="0" Id="b9232c22-c7a4-4128-ab93-ab0bc01a4c42" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="MacGymGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="MacGym_WebRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/MacGym/MacGymGroup/LB:MacGym_WebRole:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="MacGym_WebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/MacGym/MacGymGroup/MapMacGym_WebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="MacGym_WebRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/MacGym/MacGymGroup/MapMacGym_WebRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:MacGym_WebRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/MacGym/MacGymGroup/MacGym_WebRole/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapMacGym_WebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/MacGym/MacGymGroup/MacGym_WebRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapMacGym_WebRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/MacGym/MacGymGroup/MacGym_WebRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="MacGym_WebRole" generation="1" functional="0" release="0" software="D:\Projects\MacGym\MacGym\csx\Debug\roles\MacGym_WebRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;MacGym_WebRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;MacGym_WebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/MacGym/MacGymGroup/MacGym_WebRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/MacGym/MacGymGroup/MacGym_WebRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/MacGym/MacGymGroup/MacGym_WebRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="MacGym_WebRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="MacGym_WebRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="MacGym_WebRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="ee882949-26b6-4594-af7b-697980ae22a5" ref="Microsoft.RedDog.Contract\ServiceContract\MacGymContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="630faf01-52e7-463a-93c3-cdd4d9972863" ref="Microsoft.RedDog.Contract\Interface\MacGym_WebRole:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/MacGym/MacGymGroup/MacGym_WebRole:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>