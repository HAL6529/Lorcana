using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_03 : CardInfo
{
    public CardInfo_006_JA_03()
    {
        this.cardNo = "006_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "アトランティス人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolettaBaldari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
