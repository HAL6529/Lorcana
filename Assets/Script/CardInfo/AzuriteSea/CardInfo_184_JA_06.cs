using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_06 : CardInfo
{
    public CardInfo_184_JA_06()
    {
        this.cardNo = "184_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒgƒDƒNƒgƒDƒN";
        this.cardName2 = "‘å‚Á‚«‚È‘Š–_‚³‚ñ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
