using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_08 : CardInfo
{
    public CardInfo_171_JA_08()
    {
        this.cardNo = "171_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "ぬかりなき戦略家";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
