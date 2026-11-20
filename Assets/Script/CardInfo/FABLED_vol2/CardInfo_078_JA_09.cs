using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_09 : CardInfo
{
    public CardInfo_078_JA_09()
    {
        this.cardNo = "078_JA_09";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ボビー・ジムルースキー";
        this.cardName2 = "スプレーチーズ小僧";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
