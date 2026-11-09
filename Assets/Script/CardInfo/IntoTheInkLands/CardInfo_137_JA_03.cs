using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_03 : CardInfo
{
    public CardInfo_137_JA_03()
    {
        this.cardNo = "137_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "オードリー・ラミレズ";
        this.cardName2 = "機関士";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RichelleCanto;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
