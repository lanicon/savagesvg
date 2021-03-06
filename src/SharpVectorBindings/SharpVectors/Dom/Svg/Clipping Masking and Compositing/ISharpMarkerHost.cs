using System;
using System.Drawing;

namespace SharpVectors.Dom.Svg
{
	/// <summary>
	/// This is an extension to the Svg DOM. It denotes that an element can
	/// display markers.
	/// </summary>
	/// <remarks>
	/// <p>
	/// A marker is a symbol which is attached to one or more vertices of
	/// some Svg elements.  In order for a marker to be drawn correctly,
	/// its orientation and position needs to be known.
	/// See <a href="http://www.w3.org/TR/SVG/painting.html"
	/// >SVG 1.0 Masking - Establishing A New Clipping Path</a>
	/// </p>
	/// <p>
	/// This interface provides the information required to calculate the
	/// orientation and position for each marker of an Svg element.
	/// </p>
	/// <p>
	/// To give an Svg element the capability to draw markers, let the Svg
	/// element implement this interface.
	/// </p>
	/// </remarks>
	public interface ISharpMarkerHost
	{
		/// <summary>
		/// An array specifying the position of each vertex in the Svg
		/// element's shape.
		/// </summary>
		PointF[] MarkerPositions
		{
			get;
		}
		
		/// <summary>
		/// Get the angle of the path segment entering the specified vertex.
		/// </summary>
		/// <param name="index">
		/// Specifies the vertex to which the path segment is entering.
		/// </param>
		/// <returns>
		/// The angle of the path segment entering the specified vertex
		/// in degrees.
		/// </returns>
		float GetStartAngle(
			int index);
		
		/// <summary>
		/// Get the angle of the path segment leaving the specified vertex
		/// in degrees.
		/// </summary>
		/// <param name="index">
		/// Specifies the vertex from which the path segment is leaving.
		/// </param>
		/// <returns>
		/// The angle of the path segment leaving the specified vertex.
		/// </returns>
		float GetEndAngle(
			int index);
	}
}
