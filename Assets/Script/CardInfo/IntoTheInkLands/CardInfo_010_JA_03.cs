using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_03 : CardInfo
{
    public CardInfo_010_JA_03()
    {
        this.cardNo = "010_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミス・ビアンカ";
        this.cardName2 = "救助救援協会エージェント";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeffMerghart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
