using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_02 : CardInfo
{
    public CardInfo_194_JA_02()
    {
        this.cardNo = "194_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "•ºŽm";
        this.cardName2 = "•s–{ˆÓ‚ÈŽh‹q";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
