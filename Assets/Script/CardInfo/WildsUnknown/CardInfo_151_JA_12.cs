using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_12 : CardInfo
{
    public CardInfo_151_JA_12()
    {
        this.cardNo = "151_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ルイーサ・マドリガル";
        this.cardName2 = "バイバイプレッシャー";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
