<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>Students</title>
        <style>
            body {
                margin: 0px;
                padding: 0px;
            }

            .student-info {
                margin-top: 10px;
                background-color: gray;
            }
        </style>
      </head>
      <body>
        <h1>Students</h1>
        <xsl:for-each select="students/student">
          <div class="student-info">
            <b>Name</b>: <xsl:value-of select="name"/> (<xsl:value-of select="birthday"/>) <br />
            <b>Email</b>: <xsl:value-of select="email"/> <br />
            <b>Specialty</b>:  <xsl:value-of select="specialty"/> <br />
            <b>Faculty Number</b>: <xsl:value-of select="faculty-number"/> <br />
            <b>Exams</b>: <br />
            <ul>
                <xsl:for-each select="exams/exam">
                    <li>
                        <b><xsl:value-of select="name"/></b>
                        <ul>
                            <li>Grade: <b><xsl:value-of select="grade"/></b></li>
                            <li>Tutor: <xsl:value-of select="tutor"/></li>
                        </ul>
                    </li>
                </xsl:for-each>
            </ul>
          </div>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
