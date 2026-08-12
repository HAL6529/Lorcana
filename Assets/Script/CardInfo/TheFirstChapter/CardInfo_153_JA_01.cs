using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_01 : CardInfo
{
    public CardInfo_153_JA_01()
    {
        this.cardNo = "153_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "É}Å[ÉäÉì";
        this.cardName2 = "é©ëEÇÃêÊê∂";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Dave Beauchene";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
