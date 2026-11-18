using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_08 : CardInfo
{
    public CardInfo_142_JA_08()
    {
        this.cardNo = "142_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ムーシュー";
        this.cardName2 = "こわーいオバケ";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
