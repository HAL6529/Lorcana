using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_08 : CardInfo
{
    public CardInfo_015_JA_08()
    {
        this.cardNo = "015_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ライノ";
        this.cardName2 = "16分の1はオオカミ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
