using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_06 : CardInfo
{
    public CardInfo_176_JA_06()
    {
        this.cardNo = "176_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ミスター・スミー";
        this.cardName2 = "ジョリーロジャー号の船長";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
