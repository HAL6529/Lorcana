using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_05 : CardInfo
{
    public CardInfo_191_JA_05()
    {
        this.cardNo = "191_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‚²‚«‚°‚ñ";
        this.cardName2 = "Œy‰õ‚È‚é‹RŽm";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Knight, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
