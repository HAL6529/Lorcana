using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_06 : CardInfo
{
    public CardInfo_180_JA_06()
    {
        this.cardNo = "180_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒwƒ‰ƒNƒŒƒX";
        this.cardName2 = "—h‚é‚¬‚È‚¢ƒfƒ~ƒSƒbƒh";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
