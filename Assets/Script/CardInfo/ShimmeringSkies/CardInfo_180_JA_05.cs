using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_05 : CardInfo
{
    public CardInfo_180_JA_05()
    {
        this.cardNo = "180_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "‚­‚µ‚á‚Ý";
        this.cardName2 = "”š‰¹‚È‚é‹RŽm";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Knight, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
