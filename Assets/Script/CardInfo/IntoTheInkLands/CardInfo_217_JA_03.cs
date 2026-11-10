using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_217_JA_03 : CardInfo
{
    public CardInfo_217_JA_03()
    {
        this.cardNo = "217_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "É^ÉâÇ®ÇŒÇ†ÇøÇ·ÇÒ";
        this.cardName2 = "äCÇÃê∏óÏ";
        this.power = 4;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorieAndJenniferPark;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
