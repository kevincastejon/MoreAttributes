using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestHideOnPlayAttribute : MonoBehaviour
    {
        [HideOnPlay]
        [SerializeField] private int _healthPoints;

        [HideOnPlay(true)]
        [SerializeField] private int _damages;
    }
}
