using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_09 : CardInfo
{
    public CardInfo_046_JA_09()
    {
        this.cardNo = "046_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ダンボ";
        this.cardName2 = "ただ１頭の空飛ぶゾウ！";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandaraTang;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Dumbo;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
