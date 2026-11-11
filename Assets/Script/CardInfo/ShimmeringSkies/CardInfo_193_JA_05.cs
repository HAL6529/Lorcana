using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_05 : CardInfo
{
    public CardInfo_193_JA_05()
    {
        this.cardNo = "193_JA_05";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "êÊê∂";
        this.cardName2 = "çÑí_Ç»ÇÈãRém";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Knight, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
