using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_03 : CardInfo
{
    public CardInfo_187_JA_03()
    {
        this.cardNo = "187_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "パイロス";
        this.cardName2 = "ラーバタイタン";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Titan };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
