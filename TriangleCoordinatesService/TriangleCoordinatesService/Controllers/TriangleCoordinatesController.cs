using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using TriangleCoordinates.Lib;
using TriangleCoordinates.Util;


/// <summary>
/// Service classes for TriangleCoordinates
/// </summary>
namespace TriangleCoordinates.Service.Controllers
{
    /// <summary>Primary Controller class for the Web API project.</summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]")]
    public class TriangleCoordinatesController : ControllerBase
    {

        /// <summary>Gets the triangle by cell location.</summary>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns></returns>
        /// <example>[root_URL]/api/trianglecoordinates/GetTriangleByCellLocation/A1</example>
        [Route("[action]/{cellLocation}")]
        [HttpGet]
        public JsonResult GetTriangleByCellLocation(string cellLocation)
        {
            Grid grid = new Grid(Constants.ROW_COUNT, Constants.COLUMN_COUNT, Constants.CELL_SIZE);
            Triangle triangle = Calculations.GetTriangleFromCellLocation(grid, cellLocation);

            return new JsonResult(triangle);
        }

        /// <summary>Gets the cell by triangle vertices.</summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="y3">The y3.</param>
        /// <returns></returns>
        /// <example>[root_URL]/api/trianglecoordinates/GetCellByTriangleVertices/0/0/0/10/10/10</example>
        [Route("[action]/{x1}/{y1}/{x2}/{y2}/{x3}/{y3}")]
        [HttpGet]
        public JsonResult GetCellByTriangleVertices(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Grid grid = new Grid(Constants.ROW_COUNT, Constants.COLUMN_COUNT, Constants.CELL_SIZE);
            Triangle triangle = new Triangle(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3));

            return new JsonResult(Calculations.GetCellLocationFromTriangle(grid, triangle));
        }
    }
}
