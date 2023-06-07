using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuParvietosana : MonoBehaviour
{
	public Objekti objektuSkripts;

	// Update is called once per frame
	void Update()
	{
		if (objektuSkripts.pedejaissVilktais != null)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 10f);
			}

			if (Input.GetKey(KeyCode.X))
			{
				objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 10f);
			}

			if (Input.GetKey(KeyCode.UpArrow))
			{
				if (objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().localScale.y <= 0.9f)
				{
					objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale =
					new Vector2(objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.005f);

				}
			}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					if (objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().localScale.y >= 0.3f)
					{
						objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.005f);

					}
				}

            

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().localScale.x >= 0.3f)
                {
                    objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.x-0.003f,
                    objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.y);

                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().localScale.x <= 0.9f)
                {
                    objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.003f,
                    objektuSkripts.pedejaissVilktais.GetComponent<RectTransform>().transform.localScale.y);

                }
            }

        }
		}
	}

