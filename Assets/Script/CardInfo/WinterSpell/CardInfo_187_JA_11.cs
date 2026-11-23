using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_11 : CardInfo
{
    public CardInfo_187_JA_11()
    {
        this.cardNo = "187_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アンジェラ";
        this.cardName2 = "夜の戦士";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
