<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/catalog">
    <html>
      <title>Catalog</title>
      <style>
        body {
        font-family: Calibri;
        }

        table {
        border-collapse: collapse;
        }

        table, th, td {
          border: 1px solid black;
          padding: 10px;
        }
      </style>
      <body>
        <h2>Catalog</h2>
        <table border="1">
          <tr bgcolor="#dddddd">
            <th>Name</th>
            <th>Artist</th>
            <th>Year</th>
            <th>Producer</th>
            <th>Songs</th>
            <th>Price</th>
          </tr>
          <xsl:for-each select="album">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:for-each select = "songs/song">
                    <xsl:value-of select = "title"/> - <xsl:value-of select = "duration" /> <br />
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>