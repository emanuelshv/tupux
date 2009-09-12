<?xml version="1.0" encoding="UTF-8" ?>
<!--
    Document   : archivo.xsl
    Created on :  July 08, 2008
    Author     : Emanuel V. Soto Huerta
    Description:
        Purpose of transformation.
-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:output method="xml" indent="yes"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
		<!--
		<xsl:variable name="Abbrev" select="ArrayOfUMLFactor/UMLFactor/Abbrev"/>
		<xsl:variable name="Name" select="ArrayOfUMLFactor/UMLFactor/Name"/>
		-->
        <TAGDEFINITIONSET>
			<NAME>Factors</NAME>
			<BASECLASSES>
				<BASECLASS>UMLClass</BASECLASS>
			</BASECLASSES>
			<TAGDEFINITIONLIST>
		        <xsl:for-each select="ArrayOfUMLFactor/UMLFactor">
				<TAGDEFINITION lock="False">
					<NAME>(<xsl:value-of select="./Abbrev"/>)<xsl:value-of select="./Name"/></NAME>
					<TAGTYPE>Enumeration</TAGTYPE>
					<DEFAULTDATAVALUE>N</DEFAULTDATAVALUE>					
					<xsl:apply-templates select="./Values"/>
				</TAGDEFINITION>
				</xsl:for-each>
			</TAGDEFINITIONLIST>
		</TAGDEFINITIONSET>
		
    </xsl:template>
	
	<xsl:template match="Values">
        <LITERALS>
        <xsl:for-each select="./item">
           <LITERAL><xsl:value-of select="./key/string" /></LITERAL>
        </xsl:for-each>
        </LITERALS>
	</xsl:template>
 
</xsl:stylesheet>