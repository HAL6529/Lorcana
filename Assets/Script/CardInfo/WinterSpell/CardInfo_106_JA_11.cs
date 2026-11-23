using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_11 : CardInfo
{
    public CardInfo_106_JA_11()
    {
        this.cardNo = "106_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "タウラス・バルバ";
        this.cardName2 = "ギューミネーター";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
