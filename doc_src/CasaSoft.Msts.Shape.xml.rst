Assembly: CasaSoft.Msts.Shape
=============================

Type: CasaSoft.vrt.Modeling.MstsShapeFile
-----------------------------------------

 Simple class to read shape from file 

Field: CasaSoft.vrt.Modeling.MstsShapeFile.shape
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 shape data 

Method: CasaSoft.vrt.Modeling.MstsShapeFile.#ctor(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 constructor 

Parameter **filename**\: file to read and parse

Type: CasaSoft.vrt.Modeling.MstsShape
-------------------------------------

 Extends ORTS class for MSTS shape 

Method: CasaSoft.vrt.Modeling.MstsShape.#ctor(Orts.Parsers.Msts.SBR)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **block**\: 

Method: CasaSoft.vrt.Modeling.MstsShape.MinPoint
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Compute minimum of shape coords 

**Returns**\: 

Type: CasaSoft.vrt.Modeling.MstsShape.PointAndMatrix
----------------------------------------------------

 Association of point with matrix 

Field: CasaSoft.vrt.Modeling.MstsShape.PointAndMatrix.iPoint
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Index of Point 

Field: CasaSoft.vrt.Modeling.MstsShape.PointAndMatrix.iMatrix
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Index of matrix 

Field: CasaSoft.vrt.Modeling.MstsShape.MatrixOfPoint
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of points with associated matrix 

Method: CasaSoft.vrt.Modeling.MstsShape.AssociateMatrix
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Populates `Method: CasaSoft.vrt.Modeling.MstsShape.MatrixOfPoint`_

Field: CasaSoft.vrt.Modeling.MstsShape.PrecalculatedMatrices
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Precalculated matrices based on hierarchy 

Method: CasaSoft.vrt.Modeling.MstsShape.PrecalculateMatrices
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Populates `Method: CasaSoft.vrt.Modeling.MstsShape.PrecalculatedMatrices`_


