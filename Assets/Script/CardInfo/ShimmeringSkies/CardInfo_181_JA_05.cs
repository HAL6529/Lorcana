using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_05 : CardInfo
{
    public CardInfo_181_JA_05()
    {
        this.cardNo = "181_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "Ç®Ç∆Ç⁄ÇØ";
        this.cardName2 = "ãﬂÅXÇ»ÇÈãRém";
        this.power = 2;
        this.toughness = 2;
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
