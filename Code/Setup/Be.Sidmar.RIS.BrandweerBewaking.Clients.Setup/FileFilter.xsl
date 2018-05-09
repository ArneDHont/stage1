<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:wix="http://schemas.microsoft.com/wix/2006/wi"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

  <xsl:output method="xml" indent="yes"/>

  <!--Identity Transform-->
  <xsl:template match="@*|node()">
    <xsl:copy>
      <xsl:apply-templates select ="@*|node() "/>
    </xsl:copy>
  </xsl:template>

  <!--Set up keys for ignoring various file types or folders -->
  <xsl:key name="cfg-search" match="wix:Component[contains(wix:File/@Source, '.PROD.config') or 
                                                  contains(wix:File/@Source, '.QA.config') or 
                                                  contains(wix:File/@Source, '.transform.config')]" 
           use="@Id"/>
  <xsl:key name="xml-search" match="wix:Component[contains(wix:File/@Source, '.xml')]" 
           use ="@Id "/>
  <xsl:key name="ass-search" match="wix:Component[contains(wix:File/@Source, 'COMSVCS.DLL')]" 
           use="@Id"/>
  <xsl:key name="publish-search" match="wix:Component[contains(wix:File/@Source, '\app.publish\')]"
           use="@Id"/>
  <xsl:key name="host-search" match="wix:Component[contains(wix:File/@Source, '.vshost.exe')]"
           use="@Id"/>
  
  <!--Match and ignore .config files-->
  <xsl:template match="wix:Component[key('cfg-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('cfg-search', @Id)] "/>

  <!--Match and ignore leftover .xml files -->
  <xsl:template match="wix:Component[key('xml-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('xml-search', @Id)]"/>

  <!--Match and ignore assemblies-->
  <xsl:template match="wix:Component[key('ass-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('ass-search', @Id)] "/>
  
  <!--Match and ignore files in ClickOnce publish folder -->
  <xsl:template match="wix:Component[key('publish-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('publish-search', @Id)] "/>

  <!--Match and ignore Visual Studio host files -->
  <xsl:template match="wix:Component[key('host-search', @Id)]"/>
  <xsl:template match="wix:ComponentRef[key('host-search', @Id)] "/>
  
</xsl:stylesheet>
