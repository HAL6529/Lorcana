using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_05 : CardInfo
{
    public CardInfo_177_JA_05()
    {
        this.cardNo = "177_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÇÀÇ⁄Ç∑ÇØ";
        this.cardName2 = "ì›èdÇ»ÇÈãRém";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Knight, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
