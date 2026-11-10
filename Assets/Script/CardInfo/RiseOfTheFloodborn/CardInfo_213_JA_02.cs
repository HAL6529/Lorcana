using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_02 : CardInfo
{
    public CardInfo_213_JA_02()
    {
        this.cardNo = "213_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒAƒŠƒX";
        this.cardName2 = "‘å‚«‚­‚È‚Á‚¿‚á‚Á‚½";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
