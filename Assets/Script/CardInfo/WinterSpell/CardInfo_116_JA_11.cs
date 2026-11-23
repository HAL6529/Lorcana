using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_11 : CardInfo
{
    public CardInfo_116_JA_11()
    {
        this.cardNo = "116_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ネガダック";
        this.cardName2 = "反社会的人物ナンバーワン";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
